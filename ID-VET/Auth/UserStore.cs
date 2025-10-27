using System.Collections.Generic;
using System.Linq;

namespace ID_VET.Auth
{
    public class UserStore
    {
        
        private static readonly List<UserAccount> _users = new()
        {
            new UserAccount
            {
                Username = "admin",
                Password = "admin123",      // потім зробимо хешований
                Role = "Admin",
                DisplayName = "Project Admin"
            },
            new UserAccount
            {
                Username = "viewer",
                Password = "viewer123",
                Role = "User",
                DisplayName = "Guest Viewer"
            }
        };

        public UserAccount? ValidateUser(string username, string password)
        {
            return _users.FirstOrDefault(u =>
                string.Equals(u.Username, username, System.StringComparison.OrdinalIgnoreCase)
                && u.Password == password);
        }
    }
}
