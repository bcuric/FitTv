using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace FitTv.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<VideoType> Types { get; set; }
        public DbSet<Video> Videos { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}