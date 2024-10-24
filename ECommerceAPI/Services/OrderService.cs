using ECommerceAPI.Data;
using ECommerceAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ECommerceAPI.Services
{
    /// <summary>
    /// Provides methods for managing orders in the E-Commerce application.
    /// </summary>
    public class OrderService : IOrderService
    {
        private readonly ECommerceDbContext dbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderService"/> class.
        /// </summary>
        /// <param name="context">The <see cref="ECommerceDbContext"/> to be used for database operations.</param>
        public OrderService(ECommerceDbContext dbContext)
        {
            this.dbContext = dbContext; // Inject the DbContext
        }

        /// <summary>
        /// Places a new order and saves it to the database.
        /// </summary>
        /// <param name="order">The <see cref="Order"/> object to be placed.</param>
        public void PlaceOrder(Order order)
        {
            try
            {
                order.OrderDate = DateTime.Now; // Set the order date to current date and time
                dbContext.Orders.Add(order); // Add order to the DbSet
                dbContext.SaveChanges(); // Save changes to the database
            }
            catch (Exception ex)
            {
                // Log the exception (consider using a logging framework)
                Console.WriteLine($"An error occurred while placing the order: {ex.Message}");
                // Optionally, rethrow or handle the exception as needed
                throw; // Rethrow the exception after logging
            }
        }

        /// <summary>
        /// Retrieves all orders from the database.
        /// </summary>
        /// <returns>A collection of <see cref="Order"/> objects.</returns>
        public IEnumerable<Order> GetOrders()
        {
            try
            {
                return dbContext.Orders.ToList(); // Fetch orders from the database
            }
            catch (Exception ex)
            {
                // Log the exception (consider using a logging framework)
                Console.WriteLine($"An error occurred while retrieving orders: {ex.Message}");
                // Return an empty list or handle the exception as needed
                return Enumerable.Empty<Order>(); // Return an empty collection in case of an error
            }
        }
    }
}
