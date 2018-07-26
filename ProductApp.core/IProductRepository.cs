using System.Collections.Generic;

namespace ProductApp.core
{
    public interface IProductRepository
    {
        void Add(Product product);

        void Edit(Product product);

        void Remove(int Id);

        IEnumerable<Product> GetProducts();

        Product FindById(int Id);
    }
}
