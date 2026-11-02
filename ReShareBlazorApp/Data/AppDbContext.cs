using Microsoft.EntityFrameworkCore;

namespace ReShareBlazorApp.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    public DbSet<ReShare> ReShares => Set<ReShare>();
}