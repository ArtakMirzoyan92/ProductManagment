using DataAccessLayer.EntityModels;
using DataAccessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopDbContext _dbContext;

        public ProductRepository(ShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Product Add(Product product)
        {
            _dbContext.Products.Add(product);
            _dbContext.SaveChanges();
            return product;
        }

        public void Delete(Product product)
        {
            _dbContext.Products.Remove(product);
            _dbContext.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return _dbContext.Products.ToList();
        }

        public Product GetByID(int id)
        {
            return _dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public bool ProductExist(int productId)
        {
            var result = _dbContext.Products.FirstOrDefault(p => p.Id == productId);
            if (result == null)
            {
                return false;
            }
            return true;
        }

        public bool ProductExistByName(string productName)
        {
            var result = _dbContext.Products.FirstOrDefault(p => p.Name == productName);
            if (result == null)
            {
                return false;
            }
            return true;
        }

        public void Update(Product product)
        {
            
            var updateProduct = _dbContext.Products.FirstOrDefault(p => p.Id == product.Id);
            if(updateProduct==null)
            {
                Console.WriteLine("Not Found");
            }
            else if (updateProduct != null)
            {
                updateProduct.Id = product.Id;
                updateProduct.Name = product.Name;
                updateProduct.Price = product.Price;
                updateProduct.Description = product.Description;
                updateProduct.Available = product.Available;
                _dbContext.SaveChanges();
            }
            
        }
    }
}
