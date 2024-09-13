using Arabity.Data.Models;

namespace Arabity.Data.Data
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }

        public DbSet<StoreM> Stores { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Workshop> Workshops { get; set; }
        public DbSet<Image> Images { get; set; }


    }
}
