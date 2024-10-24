using ECommerceAPI.Models;
using ECommerceAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        /// <summary>
        /// Retrieves all the orders from the system.
        /// </summary>
        /// <returns>List of all orders</returns>
        [HttpGet]
        public IActionResult GetOrders()
        {
            var orders = orderService.GetOrders();
            return Ok(orders);
        }

        /// <summary>
        /// Places a new order.
        /// </summary>
        /// <param name="order">The order object to be placed</param>
        /// <returns>A success message after placing the order</returns>
        [HttpPost]
        public IActionResult PlaceOrder([FromBody] Order order)
        {
            orderService.PlaceOrder(order);
            return Ok(new { message = "Order placed successfully" });
        }
    }
}
