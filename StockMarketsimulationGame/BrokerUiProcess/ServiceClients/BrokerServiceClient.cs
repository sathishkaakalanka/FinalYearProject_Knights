using BrokerServiceHost;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;

namespace UIProcess.ServiceClients
{
    public class BrokerServiceClient : ServiceProxyBase<IBrokerService>
    {
        public BrokerServiceClient(string serviceEndPointUri, string serviceEndPointConfig)
            : base(serviceEndPointUri, serviceEndPointConfig)
        {
        }
    }
}
