using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class CompanyDetails
    {
        public Guid CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int AvailablePercentage { get; set; }
        public float UnitPrice { get; set; }
        public int PreviousUnitPrice { get; set; }      
        public DateTime CreatedDate { get; set; }
        public Guid SectorId { get; set; }
        public string SectorName { get; set; }

    }
}
