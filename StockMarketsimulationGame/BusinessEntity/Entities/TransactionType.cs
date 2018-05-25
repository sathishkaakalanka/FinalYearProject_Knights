using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class TransactionType
    {
        [Key]
        public Guid TransactionTypeId { get; set; }
        public string Transaction { get; set; }

    }
}
