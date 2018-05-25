using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class Sector
    {
        [Key]
        public Guid SectorId { get; set; }
        public string SectorName { get; set; }
      
    }
}
