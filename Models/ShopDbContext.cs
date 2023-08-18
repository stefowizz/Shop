using Microsoft.EntityFrameworkCore;

namespace shop.Models
{
    public class ShopDbContext: DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options): base (options) 
        {
            
        }
        public DbSet<Product>? Products { get; set; }   
    }
}
