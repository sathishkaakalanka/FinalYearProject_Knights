using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonRepositorie
{
    public class ValueChangeReposirory: StockMarket
    {
        StockMarket ctx = null;
        public ValueChangeReposirory(StockMarket dbCtx)
        {
            ctx = dbCtx;
        }
        public List<CompanyDetails> GetAllCompanysDetails()
        {
            List<CompanyDetails> CompanysDetails = new List<CompanyDetails>();
            CompanyDetails Company;

            var result = ctx.Database.SqlQuery<CompanyDetails>("CompaneyDetails");
            foreach (var val in result)
            {
                Company = new CompanyDetails();
                Company.CompanyId = val.CompanyId;
                Company.CompanyName = val.CompanyName;
                Company.AvailablePercentage = val.AvailablePercentage;
                Company.UnitPrice = val.UnitPrice;
                Company.PreviousUnitPrice = val.PreviousUnitPrice;
                Company.CreatedDate = val.CreatedDate;
                Company.SectorId = val.SectorId;
                Company.SectorName = val.SectorName;
                CompanysDetails.Add(Company);
            }
            return CompanysDetails;
        }
      

    }
}
