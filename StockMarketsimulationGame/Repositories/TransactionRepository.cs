using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using System.Data.SqlClient;

namespace Repositories
{
    public class TransactionRepository
    {
        StockMarket ctx = null;
        public TransactionRepository(StockMarket dbCtx)
        {
            ctx = dbCtx;
        }
        public List<Sector> GetSectorDetails()
        {
            List<Sector> SectorDetais = (from sector in ctx.Sector
                                         select sector).ToList();
            return SectorDetais;
        }
        public List<Company> GetCompaneyDetails(Guid ID)
        {
            List<Company> CompaneyDetails = (from companey in ctx.Company
                                             where companey.SectorId==ID
                                              select companey).ToList();
            return CompaneyDetails;
        }
        public List<CompanyDetails> ttttttttt(Guid ID)
        {
            List<CompanyDetails> CompaneyDetails = new List<CompanyDetails>();
            CompanyDetails CompaneyDetail;

            var selectedId = new SqlParameter("@ID", ID);

            var result = ctx.Database.SqlQuery<CompanyDetails>("CompaneyDetails  @ID", selectedId);
            foreach (var val in result)
            {
                CompaneyDetail = new CompanyDetails();
                CompaneyDetail.CompanyId = val.CompanyId;
                CompaneyDetail.CompanyName = val.CompanyName;
                CompaneyDetail.AvailablePercentage = val.AvailablePercentage;
                CompaneyDetail.UnitPrice = val.UnitPrice;
                CompaneyDetail.PreviousUnitPrice = val.PreviousUnitPrice;
                CompaneyDetail.AvailablePercentage = val.AvailablePercentage;
                CompaneyDetail.CreatedDate = val.CreatedDate;
                CompaneyDetail.CreatedDate = val.CreatedDate;
                CompaneyDetail.SectorName = val.SectorName;
                CompaneyDetails.Add(CompaneyDetail);
            }

            return CompaneyDetails;
        }
    }
}
