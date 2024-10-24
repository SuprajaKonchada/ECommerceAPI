using ECommerceAPI.Models;

namespace ECommerceAPI.Services
{
    /// <summary>
    /// Manages user sessions in the E-Commerce application.
    /// </summary>
    public class UserSessionService : IUserSessionService
    {
        private User currentUser;

        /// <summary>
        /// Retrieves the current user session.
        /// </summary>
        /// <returns>The <see cref="User"/> object representing the current user, or null if no user is set.</returns>
        public User GetUser()
        {
            return currentUser;
        }

        /// <summary>
        /// Sets the current user for the session.
        /// </summary>
        /// <param name="user">The <see cref="User"/> object to set as the current user.</param>
        public void SetUser(User user)
        {
            currentUser = user; // Set the current user for the session
        }
    }
}
