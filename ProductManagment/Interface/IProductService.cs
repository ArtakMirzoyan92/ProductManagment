using DataAccessLayer.EntityModels;
using ProductManagment.Models;

namespace ProductManagment.Interface
{
    public interface IProductService
    {
        List<ProductForResponse> GetAll();
        ProductDetails GetByID(int productId);
        ProductDetails Add(ProductForCreate product);
        void Update(ProductForUpdate product);
        void Delete(int productId);

    }
}
