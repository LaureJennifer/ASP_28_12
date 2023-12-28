using ASP_28_12.Domains.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_28_12.Domains.Entities
{
    public class Order
    {
        public Guid ID { get; set; }
        public int CustomerID { get; set; }

        public Customer Customer { get; set; }
        public DateTimeOffset OrderDate { get; set; } 

        public Status Status { get; set; } 
        public List<OrderDetails> OrderDetails { get; set; }
    }
}
