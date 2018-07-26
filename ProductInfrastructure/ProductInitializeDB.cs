using System.Data.Entity;

namespace ProductInfrastructure
{
    public class ProductInitializeDB:DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            base.Seed(context);
        }
    }
}
