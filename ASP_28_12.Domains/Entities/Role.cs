using Microsoft.AspNetCore.Identity;

namespace ASP_28_12.Domains.Entities
{
    public class Role : IdentityRole<Guid>
    {
        public string Description { get; set; }
        public virtual List<User> Users { get; set; }
    }
}
