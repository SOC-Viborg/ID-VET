namespace ID_VET.Auth
{
    public class UserAccount
    {
        public string Username { get; set; } = default!;
        public string Password { get; set; } = default!; 
        public string Role { get; set; } = "User";       
        public string DisplayName { get; set; } = default!;
    }
}