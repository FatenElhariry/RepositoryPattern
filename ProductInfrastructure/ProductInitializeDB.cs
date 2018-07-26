using System.Data.Entity;

namespace ProductApp.Infrastructure
{
    public class ProductInitializeDB:DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            context.Products.Add(new core.Product
            {
                Id = 1,
                Name = "Rice",
                inStock = true,
                Price = 100
            });

            context.Products.Add(new core.Product
            {
                Id = 2,
                Name = "Cheicken",
                inStock = true,
                Price = 500
            });
            base.Seed(context);
        }
    }
}
