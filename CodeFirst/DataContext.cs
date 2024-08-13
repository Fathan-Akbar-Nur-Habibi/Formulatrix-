using Microsoft.EntityFrameworkCore;

namespace CodeFirst;

public class DataContext : DbContext// anak dari DbContext
{
	public DbSet<Category> GetCategories {get; set;}
public DbSet<Product> Products {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = ./MyDb.db");
    }
}
