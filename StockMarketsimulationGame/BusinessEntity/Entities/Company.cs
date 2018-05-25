using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class Company
    {
        [Key]
        public Guid CompanyId { get; set; }
        public Guid SectorId { get; set; }
        public string CompanyName { get; set; }
        public int AvailablePercentage { get; set; }
        public int UnitPrice { get; set; }

       [ForeignKey("SectorId")]
        public virtual Sector Sectors { get; set; }
    }
}
