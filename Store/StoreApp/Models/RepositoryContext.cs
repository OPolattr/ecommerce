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
    }
}