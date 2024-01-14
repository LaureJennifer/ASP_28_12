using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ASP_28_12.Domains.Extensions
{
    public static class IdentityExtension
    {
        public static string GetUserId(this IPrincipal user)
        {
            if (user == null)
                return string.Empty;

            var identity = (ClaimsIdentity)user.Identity;
            IEnumerable<Claim> claims = identity.Claims;
            return claims.FirstOrDefault(s => s.Type == "UserId")?.Value;
        }
    }
}
