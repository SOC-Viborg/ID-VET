namespace ID_VET.Auth
{
    public class UserAccount
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = "User";       
        public string DisplayName { get; set; } = string.Empty;
    }
}