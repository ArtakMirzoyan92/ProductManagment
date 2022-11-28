using DataAccessLayer.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        bool ProductExistByName(string productName);
        bool ProductExist(int productId);
    }
}
