using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI.Database;

public class DataContext
{
    public DataContext(DbContextOptions options) : base (options)
    {
    }
    public DbSet<Product> Products {get; set;}
    public DbSet<Category> Categories {get; set;}

}
