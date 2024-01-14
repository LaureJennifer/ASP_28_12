using ASP_28_12.Application.Catalog.User.Request;
using ASP_28_12.Application.Login;
using ASP_28_12.Application.Register;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.Entities;

namespace ASP_28_12.Repositories
{
    public interface IUserRepository
    {
        public Task<User> Create(User user);
        public Task<User> Update(User user);
        public Task<User> Delete(User user);
        public Task<User> GetById(Guid id);
        Task<string> Authencate(LoginRequest request);
        Task<bool> Register(RegisterRequest request);
        public Task<PagedList<User>> GetAllPaging(UserPagingRequest userPagingRequest);
    }
}
