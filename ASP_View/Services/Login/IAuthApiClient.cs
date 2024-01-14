using ASP_28_12.Application.Login;

namespace ASP_View.Services.Login
{
    public interface IAuthApiClient
    {
        Task<LoginResponse> Login(LoginRequest loginRequest);
        Task Logout();
    }
}
