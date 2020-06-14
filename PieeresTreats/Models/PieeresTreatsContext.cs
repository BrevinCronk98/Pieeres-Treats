using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PieeresTreats.Models
{
    public class PieeresTreatsContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Treat> Treats{ get; set; }
        public virtual DbSet<Flavor> Flavors{ get; set; }
        public DbSet<TreatFlavor> TreatFlavors { get; set; }

        public PieeresTreatsContext(DbContextOptions options) : base(options) { }
    }
}