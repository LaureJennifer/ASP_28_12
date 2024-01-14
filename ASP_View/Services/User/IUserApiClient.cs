

using ASP_28_12.Application.Catalog.User;
using ASP_28_12.Application.Catalog.User.Request;
using ASP_28_12.Application.ViewModels.Pagination;

namespace ASP_View.Services.User
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
