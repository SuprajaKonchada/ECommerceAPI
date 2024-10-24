using ECommerceAPI.Models;
using ECommerceAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserSessionController : ControllerBase
    {
        private readonly IUserSessionService userSessionService;

        public UserSessionController(IUserSessionService userSessionService)
        {
            this.userSessionService = userSessionService;
        }

        /// <summary>
        /// Retrieves the current user session.
        /// </summary>
        /// <returns>The currently logged-in user, or a not found message if no session exists</returns>
        // GET: api/usersession
        [HttpGet]
        public IActionResult GetCurrentUser()
        {
            var user = userSessionService.GetUser();
            if (user == null)
                return NotFound(new { message = "No user session found" });
            return Ok(user);
        }

        /// <summary>
        /// Sets a new user session.
        /// </summary>
        /// <param name="user">The user object to be set in the session</param>
        /// <returns>A success message after setting the user session</returns>
        // POST: api/usersession
        [HttpPost]
        public IActionResult SetUser([FromBody] User user)
        {
            userSessionService.SetUser(user);
            return Ok(new { message = "User session set successfully" });
        }
    }
}
