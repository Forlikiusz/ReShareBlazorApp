using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace ReShareBlazorApp.Date
{
    public class ReshareDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ReshareDbContext(DbContextOptions<ReshareDbContext> options)
            : base(options)
        {
            
        }
    }
}
