﻿

using ASP_28_12.Application.Catalog.UserApp.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.Entities;

namespace ASP_View.Services.UserSer
{
    public interface IUserApiClient
    {
        Task<PagedList<User>> GetUser(UserPagingRequest userPagingRequest);
        Task<User> GetUserDetails(string id);

        Task<bool> CreateUser(UserCreateRequest userCreateRequest);
        Task<bool> UpdateUser(Guid id, UserUpdateRequest userUpdateRequest);

        Task<bool> DeleteUser(Guid id);
    }
}
