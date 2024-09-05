using Microsoft.EntityFrameworkCore;

namespace ConsoleApp22;

public class shop:DbContext
{
    public DbSet<product> products { get; set; }
    public DbSet<Category> categories { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=STHQ0126-08;Initial Catalog = Shop1Db;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        base.OnConfiguring(optionsBuilder);
    }
}
