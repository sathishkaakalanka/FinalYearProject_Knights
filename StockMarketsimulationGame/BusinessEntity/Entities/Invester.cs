using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class Invester
    {
        [Key]
        public Guid InvesterId { get; set; }
        public string InvesterName { get; set; }
        public string password { get; set; }
        public string Email { get; set; }
        public int status { get; set; }

        
    }
}
