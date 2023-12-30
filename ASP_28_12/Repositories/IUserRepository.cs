using ASP_28_12.Application.Catalog.ProductApp.Request;
using ASP_28_12.Application.Catalog.UserApp.Request;
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
        public Task<PagedList<User>> GetAllPaging(UserPagingRequest userPagingRequest);
    }
}
