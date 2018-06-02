using System;
using BusinessBL;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace InvestorserviceHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "InvestorService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select InvestorService.svc or InvestorService.svc.cs at the Solution Explorer and start debugging.
    public class InvestorService : IInvestorService
    {
      public bool GetLoggedUser(string UserName, string Logged)
        {
            return new LoggedUserBL().GetLoggedUser(UserName, Logged);
        }
        
       public bool CreateNewUser(string username, string Email, string Password)
        {
            return new LoggedUserBL().CreateNewUser(username, Email, Password);
        }

       public bool GetUserPassword(string UserName)
        {
            return new LoggedUserBL().GetUserPassword(UserName);
        }

    }
}
