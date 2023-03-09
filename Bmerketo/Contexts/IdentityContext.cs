using Bmerketo.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bmerketo.Contexts
{
    public class IdentityContext : IdentityDbContext
    {
        public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
        {
        }

        public DbSet<IdentityUserProfile> UserProfiles { get; set; }
    }
}
