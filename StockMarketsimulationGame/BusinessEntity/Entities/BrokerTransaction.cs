using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class BrokerTransaction
    {
        [Key]
        public Guid TransactionId { get; set; }
       // public Guid BankAccountId { get; set; }
        public Guid BrokerId { get; set; }
        public Guid CompanyId { get; set; }
        public int ShereAmount { get; set; }
        public double UnitPrice { get; set;}
        public DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }


        [ForeignKey("BrokerId")]
        public virtual Broker Brokers { get; set; }
        [ForeignKey("CompanyId")]
        public virtual Company Companys { get; set; }
        //[ForeignKey("BankAccountId")]
       // public virtual BankAccount BankAccounts { get; set; }
    }
}
