using ASP_28_12.Application.Catalog.UserApp.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.Entities;
using Microsoft.AspNetCore.WebUtilities;

namespace ASP_View.Services.UserSer
{
    public class UserApiClient : IUserApiClient
    {
        public HttpClient _httpClient;

        public UserApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<bool> CreateUser(UserCreateRequest userCreateRequest)
        {
            var result = await _httpClient.PostAsJsonAsync("api/user", userCreateRequest);
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteUser(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"api/user/{id}");
            return result.IsSuccessStatusCode;
        }

        public async Task<PagedList<User>> GetUser(UserPagingRequest userPagingRequest)
        {
            var queryStringPara = new Dictionary<string, string>
            {
                ["pageNumber"] = userPagingRequest.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(userPagingRequest.UserName)) queryStringPara.Add("username", userPagingRequest.UserName);
            string url = QueryHelpers.AddQueryString("/api/user", queryStringPara);
            var result = await _httpClient.GetFromJsonAsync<PagedList<User>>(url);
            return result;
        }

        public async Task<User> GetUserDetails(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<User>($"/api/user/{id}");
            return result;
        }

        public async Task<bool> UpdateUser(Guid id, UserUpdateRequest userUpdateRequest)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/user/{id}", userUpdateRequest);
            return result.IsSuccessStatusCode;
        }
    }
}
