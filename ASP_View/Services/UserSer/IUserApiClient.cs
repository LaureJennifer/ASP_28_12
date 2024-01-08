

using ASP_28_12.Application.Catalog.UserApp;
using ASP_28_12.Application.Catalog.UserApp.Request;
using ASP_28_12.Application.ViewModels.Pagination;

namespace ASP_View.Services.UserSer
{
    public interface IUserApiClient
    {
        Task<PagedList<UserDto>> GetUser(UserPagingRequest userPagingRequest);
        Task<UserDto> GetUserDetails(string id);

        Task<bool> CreateUser(UserCreateRequest userCreateRequest);
        Task<bool> UpdateUser(Guid id, UserUpdateRequest userUpdateRequest);

        Task<bool> DeleteUser(Guid id);
    }
}
