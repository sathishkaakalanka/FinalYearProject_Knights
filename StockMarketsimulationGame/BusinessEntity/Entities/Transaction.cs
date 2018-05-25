using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class Transaction
    {
        [Key]
        public Guid TransactionId { get; set; }
        public Guid BankAccountId { get; set; }
        public Guid BrokerId { get; set; }
        public Guid InvesterId { get; set; }
        public Guid TransactionTypeId { get; set; }
        public double Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        [ForeignKey("BrokerId")]
        public virtual Broker Brokers { get; set; }
        [ForeignKey("InvesterId")]
        public virtual Invester Investers { get; set; }
        [ForeignKey("TransactionTypeId")]
        public virtual TransactionType TransactionTypes { get; set; }
        [ForeignKey("BankAccountId")]
        public virtual BankAccount BankAccounts { get; set; }
    }
}
