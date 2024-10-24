using ECommerceAPI.Models;

namespace ECommerceAPI.Services
{
    /// <summary>
    /// Defines the contract for order-related operations.
    /// </summary>
    public interface IOrderService
    {
        /// <summary>
        /// Places a new order.
        /// </summary>
        /// <param name="order">The order to be placed.</param>
        void PlaceOrder(Order order);

        /// <summary>
        /// Retrieves all orders placed by users.
        /// </summary>
        /// <returns>A collection of all orders.</returns>
        IEnumerable<Order> GetOrders();
    }
}
