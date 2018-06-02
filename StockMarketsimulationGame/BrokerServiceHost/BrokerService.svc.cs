using System;
using BrokerBusinessBL;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BrokerServiceHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BrokerService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BrokerService.svc or BrokerService.svc.cs at the Solution Explorer and start debugging.
    public class BrokerService : IBrokerService
    {
      public string checkwork()
        {
            return new LoggedBrokerBL().checkwork();
        }
    }
}
