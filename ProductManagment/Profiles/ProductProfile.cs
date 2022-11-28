using AutoMapper;
using DataAccessLayer.EntityModels;
using ProductManagment.Models;

namespace ProductManagment.Profiles
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDetails>();
            CreateMap<Product, ProductForResponse>();
            CreateMap<ProductForCreate, Product>();
            CreateMap<ProductForUpdate, Product>();

        }
    }
}
