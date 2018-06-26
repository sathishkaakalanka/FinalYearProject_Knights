using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories;
using BusinessEntity;

namespace BusinessBL
{
    public class TransationBL
    {
        StockMarket ctx = new StockMarket();
        public List<Sector> GetBrokerDetail()
        {
            var brokerdetail = new TransactionRepository(ctx).GetSectorDetails();               
            return brokerdetail;
        }

        public List<Company> GetCompaneyDetails(Guid ID)
        {
            var Commanydetail = new TransactionRepository(ctx).GetCompaneyDetails(ID);
            return Commanydetail;
        }
    }
}
