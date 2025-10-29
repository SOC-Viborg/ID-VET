using System.Threading.Tasks;

namespace ID_VET.Auth
{
    public class AuthService
    {
        private readonly UserStore _userStore;
        private readonly CustomAuthStateProvider _authStateProvider;

        public AuthService(UserStore userStore, CustomAuthStateProvider authStateProvider)
        {
            _userStore = userStore;
            _authStateProvider = authStateProvider;
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            Console.WriteLine($"LOGIN ATTEMPT: {username}, {password}");

            var user = _userStore.ValidateUser(username, password);
            if (user == null)
            {
                Console.WriteLine("❌ User not found");
                return false;
            }
            Console.WriteLine($"✅ User validated: {user.DisplayName}");
            await _authStateProvider.SignIn(user);
            return true;
        }

        public async Task LogoutAsync()
        {
            await _authStateProvider.SignOut();
        }
    }
}
