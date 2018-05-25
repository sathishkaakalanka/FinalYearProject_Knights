using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class Bank
    {
        [Key]
        public Guid BankId { get; set; }
        public string BankName { get; set; }
      
    }
}
