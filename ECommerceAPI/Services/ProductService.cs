using ECommerceAPI.Data;
using ECommerceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommerceAPI.Services
{
    /// <summary>
    /// Provides methods for managing products in the E-Commerce application.
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly ECommerceDbContext dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductService"/> class.
        /// </summary>
        /// <param name="context">The <see cref="ECommerceDbContext"/> to be used for database operations.</param>
        public ProductService(ECommerceDbContext dbContext)
        {
            this.dbContext = dbContext; // Inject the DbContext
        }

        /// <summary>
        /// Retrieves all products from the database.
        /// </summary>
        /// <returns>A collection of <see cref="Product"/> objects.</returns>
        public IEnumerable<Product> GetProducts()
        {
            try
            {
                return dbContext.Products.ToList(); // Fetch products from the database
            }
            catch (Exception ex)
            {
                // Log the exception (consider using a logging framework)
                Console.WriteLine($"An error occurred while retrieving products: {ex.Message}");
                // Return an empty list or handle the exception as needed
                return Enumerable.Empty<Product>(); // Return an empty collection in case of an error
            }
        }

        /// <summary>
        /// Adds a new product to the database.
        /// </summary>
        /// <param name="product">The <see cref="Product"/> object to be added.</param>
        public void AddProduct(Product product)
        {
            try
            {
                dbContext.Products.Add(product); // Add product to the DbSet
                dbContext.SaveChanges(); // Save changes to the database
            }
            catch (Exception ex)
            {
                // Log the exception (consider using a logging framework)
                Console.WriteLine($"An error occurred while adding the product: {ex.Message}");
                // Optionally, rethrow or handle the exception as needed
                throw; // Rethrow the exception after logging
            }
        }
    }
}
