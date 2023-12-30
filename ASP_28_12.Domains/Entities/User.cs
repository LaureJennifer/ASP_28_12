using Microsoft.AspNetCore.Identity;

namespace ASP_28_12.Domains.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string Address { get; set; }
        public DateTimeOffset CreatedDate { get; set; }

        public List<Order> Orders { get; set; }

    }

}