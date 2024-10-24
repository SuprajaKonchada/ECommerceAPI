using ECommerceAPI.Models;
using ECommerceAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        /// <summary>
        /// Retrieves all products from the system.
        /// </summary>
        /// <returns>List of all products</returns>
        // GET: api/product
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = productService.GetProducts();
            return Ok(products);
        }

        /// <summary>
        /// Adds a new product to the system.
        /// </summary>
        /// <param name="product">The product object to be added</param>
        /// <returns>A success message after adding the product</returns>
        // POST: api/product
        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            productService.AddProduct(product);
            return Ok(new { message = "Product added successfully" });
        }
    }
}
