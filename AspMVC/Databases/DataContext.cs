using Microsoft.EntityFrameworkCore;
using AspMVC.Models;
namespace AspMVC.Databases;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Category> Categories {get; set;}
    public DbSet<Product> Products {get; set;}
}
