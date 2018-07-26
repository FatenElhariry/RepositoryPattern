using ProductApp.core;
using System.Data.Entity;


namespace ProductInfrastructure
{
    public class ProductContext:DbContext
    {
        public ProductContext():base("name=ProductAppConnectionString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Product> Products { get; set; }
    }
}
