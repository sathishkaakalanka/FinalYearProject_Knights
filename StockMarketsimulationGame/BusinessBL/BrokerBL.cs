using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using BusinessEntity;

namespace BusinessBL
{
    public class BrokerBL
    {
        public Broker GetBrokerDetail()
        {
            var brokerdetail = new BrokerRepository().GetBrokerDetail();
            return brokerdetail;
        }
    }
}
