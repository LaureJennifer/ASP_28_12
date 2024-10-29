using Microsoft.AspNetCore.Identity;

namespace ASP_28_12.Domains.Entities
{
    public class User : IdentityUser<Guid>
    {
        public Guid RoleId { get; set; }
        public string Address { get; set; }
        public DateTimeOffset CreatedDate { get; set; }

        public string UrlImage { get; set; }
        public List<Order> Orders { get; set; }
        public virtual Role Role { get; set; }

    }

}