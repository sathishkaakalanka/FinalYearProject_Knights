using InvestorserviceHost;
using System;
using System.Collections.Generic;
using UIProcess.ServiceClients;
using System.Text;
using System.Threading.Tasks;

namespace UIProcess
{
    public class LoggedUserUIProcess: ServiceProxyBase<IInvestorService>
    {
        private static string _serviceEndPointConfig;
        public LoggedUserUIProcess() : base(new Endpoint().GetEndPointUri("BasicHttpBinding_IInvestorService", out _serviceEndPointConfig), _serviceEndPointConfig)
        {
        }

        public bool GetLoggedUser(string UserName, string Logged)
        {
            return Channel.GetLoggedUser(UserName, Logged);
        }
       public bool CreateNewUser(string username, string Email, string Password)
        {
            return Channel.CreateNewUser(username, Email, Password);
        }
        public bool GetUserPassword(string UserName)
        {
            return Channel.GetUserPassword(UserName);
        }
    }
}
