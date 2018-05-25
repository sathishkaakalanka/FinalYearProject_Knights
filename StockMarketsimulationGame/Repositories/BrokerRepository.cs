using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;

namespace Repositories
{
    public class BrokerRepository
    {
        public Broker GetBrokerDetail()
        {
            Broker broker = new Broker();
            broker.BrokerId = Guid.NewGuid();
           // broker.BrokerName = "NDB Bank";
           // broker.InvesterId=new Guid();
            return broker;
        }
    }
}
