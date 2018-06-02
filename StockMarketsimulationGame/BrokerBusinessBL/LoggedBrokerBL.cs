using BrokerRepository;
using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerBusinessBL
{
    public class LoggedBrokerBL
    {
        StockMarket ctx = new StockMarket();

        public string checkwork()
        {
            var rest = new LoggedBrokerRepository(ctx).checkwork();
            return rest;
        }
    }
}
