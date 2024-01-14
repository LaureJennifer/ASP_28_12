using ASP_28_12.Application.Login;
using ASP_View.Data;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Text.Json;

namespace ASP_View.Services.Login
{
    public class AuthApiClient : IAuthApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public AuthApiClient(HttpClient httpClient,AuthenticationStateProvider authenticationStateProvider,ILocalStorageService localStorageService)
        {
            _httpClient = httpClient;
            _localStorage = localStorageService;
            _authenticationStateProvider = authenticationStateProvider;
        }

       
        public async Task<LoginResponse> Login(LoginRequest loginRequest)
        {
            var result = await _httpClient.PostAsJsonAsync("/api/login/authenticate", loginRequest);
            var content = await result.Content.ReadAsStringAsync();
            var loginResponse = JsonSerializer.Deserialize<LoginResponse>(content, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            }) ;
            if (!result.IsSuccessStatusCode)
            {
                return loginResponse;
            }
            await _localStorage.SetItemAsync("authToken", loginResponse.Token);
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(loginRequest.UserName);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer",loginResponse.Token);
            return loginResponse;
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }
    }
}
