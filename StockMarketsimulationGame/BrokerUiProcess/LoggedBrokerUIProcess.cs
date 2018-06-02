using BrokerServiceHost;
using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using UIProcess.ServiceClients;

namespace BrokerUIProcess
{
    public class LoggedBrokerUIProcess : ServiceProxyBase<IBrokerService>
    {
        private static string _serviceEndPointConfig;
        public LoggedBrokerUIProcess() : base(new EndpointBroker().GetEndPointUri("BasicHttpBinding_IBrokerService1", out _serviceEndPointConfig), _serviceEndPointConfig)
        {
        }
        public string checkwork()
        {
            return Channel.checkwork();
        }
    }
}
