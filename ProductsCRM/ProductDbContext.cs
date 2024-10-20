using Microsoft.EntityFrameworkCore;
using ProductsCRM.Models;

namespace ProductsCRM;

public sealed class ProductDbContext(DbContextOptions<ProductDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
}