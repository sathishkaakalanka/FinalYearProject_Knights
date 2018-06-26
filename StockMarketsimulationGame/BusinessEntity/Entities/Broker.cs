using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
{
    public class Broker
    {
        [Key]
        public Guid BrokerId { get; set; }
        public string BrokerName { get; set; }
        public string password { get; set; }
        public string Email { get; set; }

    }
}
