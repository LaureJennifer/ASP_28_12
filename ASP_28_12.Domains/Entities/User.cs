using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_28_12.Domains.Entities
{
    public class User:IdentityUser<Guid>
    {
        public string Address { get; set; }

        public List<Order> Orders { get; set; }

    }

}