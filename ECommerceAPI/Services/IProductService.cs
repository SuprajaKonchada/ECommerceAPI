using ECommerceAPI.Models;

namespace ECommerceAPI.Services
{
    /// <summary>
    /// Defines the contract for product-related operations.
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// Retrieves all available products.
        /// </summary>
        /// <returns>A collection of all products.</returns>
        IEnumerable<Product> GetProducts();

        /// <summary>
        /// Adds a new product to the product catalog.
        /// </summary>
        /// <param name="product">The product to be added.</param>
        void AddProduct(Product product);
    }
}
