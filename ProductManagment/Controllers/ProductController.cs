using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagment.Interface;
using ProductManagment.Models;

namespace ProductManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("GetAllProducts")]
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpGet]
        [Route("GetByID")]
        public IActionResult GetAll(int productId)
        {
            var result = _productService.GetByID(productId);
            if (result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost]
        [Route("AddProduct")]
        public IActionResult Add(ProductForCreate product)
        {
            var result = _productService.Add(product);
            if (result == null)
                return BadRequest("product name already exist");
            return Ok(result);
        }

        [HttpPut]
        [Route("UpdateProduct")]
        public IActionResult Update(ProductForUpdate product)
        {
                     
            _productService.Update(product);           
            return Ok();
        }

        [HttpDelete]
        [Route("DeleteProduct")]
        public IActionResult Delete(int productId)
        {
            _productService.Delete(productId);
            return Ok();
        }
    }
}
