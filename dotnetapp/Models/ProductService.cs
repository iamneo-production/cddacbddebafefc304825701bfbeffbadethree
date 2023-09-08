using dotnetapp.Models;
using System.Linq;

namespace dotnetapp.Models
{
    public interface IProductService
    {
        public IQueryable<Product> GetProductList();
        public bool AddProduct(Product product);
        public bool DeleteProduct(int Id);
    }
    //Fill ur code
    public class ProductService : IProductService
    {
       private readonly ProductDBContext _dbContext;

        public ProductService(ProductDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IQueryable<Product> GetProductList()
        {
           IQueryable<Product> productlist = dbContext.Products() 
           return productlist;
        }
        public bool AddProduct(Product product)
        {
            Products.Add(product);
            return true;
        }

        public bool DeleteProduct(int Id)
        {
            Product p = Products.Find(Id);
            Products.Remove(p);
            return true;
        }
    }
}