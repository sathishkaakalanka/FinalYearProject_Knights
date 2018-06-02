using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace InvestorserviceHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IInvestorService" in both code and config file together.
    [ServiceContract]
    public interface IInvestorService
    {
        [OperationContract]
        bool GetLoggedUser(string UserName, string Logged);

        [OperationContract]
        bool CreateNewUser(string username, string Email, string Password);

        [OperationContract]
        bool GetUserPassword(string UserName);
      
    }
}
