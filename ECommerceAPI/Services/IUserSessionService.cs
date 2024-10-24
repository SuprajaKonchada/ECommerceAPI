using ECommerceAPI.Models;

namespace ECommerceAPI.Services
{
    /// <summary>
    /// Defines the contract for user session management operations.
    /// </summary>
    public interface IUserSessionService
    {
        /// <summary>
        /// Retrieves the details of the currently set user.
        /// </summary>
        /// <returns>The user object containing user details.</returns>
        User GetUser();

        /// <summary>
        /// Sets the user details.
        /// </summary>
        /// <param name="user">The user object containing user information to be set.</param>
        void SetUser(User user);
    }
}
