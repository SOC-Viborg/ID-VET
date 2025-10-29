using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using ID_VET.Auth;


    public class LoginBase : ComponentBase
    {
        [Inject] protected AuthService AuthService { get; set; } = default!;
        [Inject] protected NavigationManager Nav { get; set; } = default!;

        private LoginModel LoginModel { get; set; } = new();
        public string? ErrorMessage;

        protected async Task HandleLogin()
        {
            var success = await AuthService.LoginAsync(LoginModel.Username, LoginModel.Password);
            if (success)
            {
                Nav.NavigateTo("/");
            }
            else
            {
                ErrorMessage = "Invalid username or password.";
            }
        }
    }

