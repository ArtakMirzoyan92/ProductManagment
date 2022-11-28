using AutoMapper;
using DataAccessLayer.EntityModels;
using DataAccessLayer.Interfaces;
using ProductManagment.Interface;
using ProductManagment.Models;

namespace ProductManagment.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository,IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public ProductDetails Add(ProductForCreate product)
        {
            if (_productRepository.ProductExistByName(product.Name))
                return null;

            Product dbProduct = _mapper.Map<Product>(product);
            dbProduct.Available = true;
            dbProduct.DateCreated = DateTime.Now;
            Product productFromDb = _productRepository.Add(dbProduct);
            ProductDetails productDetails = _mapper.Map<ProductDetails>(productFromDb);
            return productDetails;
        }

        public void Delete(int productId)
        {
            Product dbProduct = _productRepository.GetByID(productId);
            if (dbProduct != null)
            {
                _productRepository.Delete(dbProduct);
            }
        }

        public List<ProductForResponse> GetAll()
        {
            List<Product> dbProducts = _productRepository.GetAll();
            List<ProductForResponse> productForResponses = _mapper.Map<List<ProductForResponse>>(dbProducts);
            return productForResponses;
        }

        public ProductDetails GetByID(int productId)
        {
            Product dbProduct = _productRepository.GetByID(productId);
            ProductDetails productDetails = _mapper.Map<ProductDetails>(dbProduct);
            return productDetails;
        }

        public void Update(ProductForUpdate product)
        {
            Product dbProduct = _mapper.Map<Product>(product);
            _productRepository.Update(dbProduct);
        }
    }
}
