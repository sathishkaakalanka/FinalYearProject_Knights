using BrokerServiceHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIProcess.ServiceClient;


namespace BrokerUIProcess
{
    public class LoggedBrokerUIProcess : ServiceProxyBaseBroker<IBrokerService>
    {
        private static string _serviceEndPointConfig;
        public LoggedBrokerUIProcess() : base(new EndpointBroker().GetEndPointUri("BasicHttpBinding_IBrokerService1", out _serviceEndPointConfig), _serviceEndPointConfig)
        {
        }
        public bool GetLoggedBroker(string UserName, string Logged)
        {
            return Channel.GetLoggedBroker(UserName, Logged);
        }
        public bool CreateNewBroker(string username, string Email, string Password)
        {
            return Channel.CreateNewBroker(username, Email, Password);
        }
        public bool GetBrokerPassword(string UserName)
        {
            return Channel.GetBrokerPassword(UserName);
        }
    }
}
