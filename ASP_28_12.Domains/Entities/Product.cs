using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_28_12.Domains.Entities
{
    public class Product
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
    }
}
