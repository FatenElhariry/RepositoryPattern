using ProductApp.core;
using System.Collections.Generic;
using System.Linq;

namespace ProductApp.Infrastructure
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public ProductRepository()
        {
            _context = new ProductContext();
        }
        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Edit(Product product)
        {
            _context.Entry(product).State = System.Data.Entity.EntityState.Modified;
        }

        public Product FindById(int Id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == Id);
        }

        public IEnumerable<Product> GetProducts()
        {
           return  _context.Products.ToList();
        }

        public void Remove(int Id)
        {
            var product = _context.Products.Find(Id);
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }
}
