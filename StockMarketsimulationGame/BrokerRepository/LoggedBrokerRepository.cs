using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerRepository
{
    public class LoggedBrokerRepository
    {
        StockMarket ctx = null;
        public LoggedBrokerRepository(StockMarket dbCtx)
        {
            ctx = dbCtx;
        }
        public string checkwork()
        {
            var test = "test path";
            return test;
        }
    }
}
