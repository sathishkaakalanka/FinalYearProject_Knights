
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace UIProcess.ServiceClients
{
    public class ServiceProxyBase<T> : IDisposable where T : class
    {
        private readonly string _serviceEndPointUri;
        private readonly string _serviceEndPointConfig;
        private readonly object _sync = new object();
        private IChannelFactory<T> _channelFactory;
        private T _channel;
        private bool _disposed = false;

        protected ServiceProxyBase(string serviceEndPointUri, string serviceEndPointConfig)
        {
            _serviceEndPointUri = serviceEndPointUri;
            _serviceEndPointConfig = serviceEndPointConfig;
        }

        #region IDisposable

        ~ServiceProxyBase()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposeManaged)
        {
            if (_disposed) return;
            if (disposeManaged)
            {
                lock (_sync)
                {
                    CloseChannel();
                    if (_channelFactory != null)
                    {
                        ((IDisposable)_channelFactory).Dispose();
                    }
                    _channel = null;
                    _channelFactory = null;
                }
            }
            _disposed = true;
        }

        #endregion

        protected T Channel
        {
            get
            {
                Initialise();
                return _channel;
            }
        }
        protected void CloseChannel()
        {
            if (_channel != null)
            {
                ((ICommunicationObject)_channel).Close();
            }
        }
        private void Initialise()
        {
            lock (_sync)
            {
                if (_channel != null) return;

                _channelFactory = new ChannelFactory<T>(new BasicHttpBinding(_serviceEndPointConfig));
                _channel = _channelFactory.CreateChannel(new EndpointAddress(_serviceEndPointUri));
            }
        }
    }
}
