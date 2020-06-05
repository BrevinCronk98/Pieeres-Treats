using Microsoft.AspNetCore.Identity;

namespace PieeresTreats.Models
{
    public class ApplicationUser : IdentityUser
    {
        public override string UserName { get; set; }
    }
}