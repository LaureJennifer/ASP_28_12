﻿using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;

namespace ASP_View.Data
{
    public class ApiAuthenticationStateProvider : AuthenticationStateProvider
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;

        public ApiAuthenticationStateProvider(HttpClient httpClient, ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            try
            {
                string token = await _localStorage.GetItemAsync<string>("authToken");
                var identity = new ClaimsIdentity();
                _httpClient.DefaultRequestHeaders.Authorization = null;

                if (!string.IsNullOrEmpty(token))
                {
                    identity = new ClaimsIdentity(ParseClaimsFromJwt(token), "jwt");
                    _httpClient.DefaultRequestHeaders.Authorization =
                        new AuthenticationHeaderValue("Bearer", token.Replace("\"", ""));
                }

                var user = new ClaimsPrincipal(identity);
                var state = new AuthenticationState(user);

                NotifyAuthenticationStateChanged(Task.FromResult(state));

                return state;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving authentication state: {ex.Message}");
                  return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
            }

        }
        //public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        //{
        //    try
        //    {
        //        var savedToken = await _localStorage.GetItemAsync<string>("authToken");

        //        if (string.IsNullOrWhiteSpace(savedToken))
        //        {
        //            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));
        //        }

        //        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", savedToken);

        //        return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(ParseClaimsFromJwt(savedToken), "jwt")));
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error retrieving authentication state: {ex.Message}");
        //        return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));

        //    }
        //}
        public void MarkUserAsAuthenticated(string userName)
        {
            var authenticatedUser = new ClaimsPrincipal(new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, userName) }, "apiauth"));
            var authState = Task.FromResult(new AuthenticationState(authenticatedUser));
            NotifyAuthenticationStateChanged(authState);
        }

        public void MarkUserAsLoggedOut()
        {
            var anonymousUser = new ClaimsPrincipal(new ClaimsIdentity());
            var authState = Task.FromResult(new AuthenticationState(anonymousUser));
            NotifyAuthenticationStateChanged(authState);
        }

        private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var claims = new List<Claim>();
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

            keyValuePairs.TryGetValue(ClaimTypes.Role, out object roles);

            if (roles != null)
            {
                if (roles.ToString().Trim().StartsWith("["))
                {
                    var parsedRoles = JsonSerializer.Deserialize<string[]>(roles.ToString());

                    foreach (var parsedRole in parsedRoles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, parsedRole));
                    }
                }
                else
                {
                    claims.Add(new Claim(ClaimTypes.Role, roles.ToString()));
                }

                keyValuePairs.Remove(ClaimTypes.Role);
            }

            claims.AddRange(keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString())));

            return claims;
        }

        private byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }
    }
}
