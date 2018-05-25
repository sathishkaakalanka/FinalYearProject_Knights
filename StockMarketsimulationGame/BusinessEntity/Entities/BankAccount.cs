using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class BankAccount
    {
        [Key]
        public Guid BankAccountId { get; set; }
        public string BankAccountName { get; set; }
        public Guid BankId { get; set; }

        [ForeignKey("BankId")]
        public virtual Bank Banks { get; set; }
    }
}
