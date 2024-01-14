using ASP_28_12.Application.Catalog.User;
using ASP_28_12.Application.Catalog.User.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using Microsoft.AspNetCore.WebUtilities;

namespace ASP_View.Services.User
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

        public async Task<PagedList<UserDto>> GetUser(UserPagingRequest userPagingRequest)
        {
            var queryStringPara = new Dictionary<string, string>
            {
                ["pageNumber"] = userPagingRequest.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(userPagingRequest.UserName)) queryStringPara.Add("username", userPagingRequest.UserName);
            string url = QueryHelpers.AddQueryString("/api/user", queryStringPara);
            var result = await _httpClient.GetFromJsonAsync<PagedList<UserDto>>(url);
            return result;
        }

        public async Task<UserDto> GetUserDetails(string id)
        {

            var result = await _httpClient.GetFromJsonAsync<UserDto>($"/api/user/{id}");
            return result;
        }

        public async Task<bool> UpdateUser(Guid id, UserUpdateRequest userUpdateRequest)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/user/{id}", userUpdateRequest);
            return result.IsSuccessStatusCode;
        }
    }
}
