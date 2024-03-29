using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models
{
    public class RepositoryContext : DbContext
    {
        //productları tutup bunları tabloya yansıtır.
        public DbSet<Product> Products { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        :base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product(){ProductId=1,ProductName="Computer", ProductPrice=17_000},
                new Product(){ProductId=2,ProductName="Keyboard", ProductPrice=1_000},
                new Product(){ProductId=3,ProductName="Mouse", ProductPrice=500},
                new Product(){ProductId=4,ProductName="Monitor", ProductPrice=7_000},
                new Product(){ProductId=5,ProductName="Deck", ProductPrice=1_500}
            );
        }
    }
}