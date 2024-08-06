using ProductsAPI.Context;
using ProductsAPI.Domains;
using ProductsAPI.Interfaces;

namespace ProductsAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductsAPIContext _ctx;

        public ProductRepository()
        {
            _ctx = new ProductsAPIContext();
        }

        public void Delete(Guid id)
        {
            var product = _ctx.Products.FirstOrDefault(x => x.IdProduct == id);

            if (product != null)
            {
                _ctx.Products.Remove(product);
            }
            _ctx.SaveChanges();
        }

        public List<Product> Get()
        {
            return _ctx.Products.ToList();
        }

        public Product GetById(Guid id)
        {
            return _ctx.Products.FirstOrDefault(x => x.IdProduct == id);
        }

        public void Post(Product product)
        {
            _ctx.Add(product);
            _ctx.SaveChanges();
        }

        public void Put(Guid id,Product product)
        {
            var newProduct = _ctx.Products.FirstOrDefault(x => x.IdProduct == id);

            if (newProduct != null)
            {
                if (product.Name != null)
                {
                    newProduct.Name = product.Name;
                }

                if (product.Price.HasValue)
                {
                    newProduct.Price = product.Price;
                }
            }

            _ctx.SaveChanges();
        }
    }
}
