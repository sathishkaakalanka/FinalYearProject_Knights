using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class CompanyVersion
    {
        [Key]
        public Guid CompanyVersionId { get; set; }
        public Guid CompanyId { get; set; }
        public int UnitPrice { get; set; }
        public DateTime CreatedDate { get; set; }

        [ForeignKey("CompanyId")]
        public virtual Company Companies { get; set; }
    }
}
