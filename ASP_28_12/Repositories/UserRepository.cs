using ASP_28_12.Application.Catalog.UserApp.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.EF;
using ASP_28_12.Domains.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP_28_12.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly FlowerDbContext _db;

        public UserRepository(FlowerDbContext dbcontext)
        {
            _db = dbcontext;
        }

        public async Task<User> Create(User user)
        {
            await _db.Users.AddAsync(user);
            await _db.SaveChangesAsync();
            return user;
        }

        public async Task<User> Delete(User user)
        {
            _db.Users.Remove(user);
            await _db.SaveChangesAsync();
            return user;
        }

        public async Task<PagedList<User>> GetAllPaging(UserPagingRequest userPagingRequest)
        {
            var query = _db.Users.Include(x => x.Orders).AsQueryable();

            if (!string.IsNullOrEmpty(userPagingRequest.UserName))
            {
                query = query.Where(x => x.UserName.ToLower().Contains(userPagingRequest.UserName.ToLower()));
            }
            var count = await query.CountAsync();
            var data = await query.OrderByDescending(x => x.CreatedDate)
            .Skip((userPagingRequest.PageNumber - 1) * userPagingRequest.PageSize)
            .Take(userPagingRequest.PageSize).ToListAsync();
            return new PagedList<User>(data, count, userPagingRequest.PageNumber, userPagingRequest.PageSize);
        }

        public async Task<User> GetById(Guid id)
        {
            return await _db.Users.FindAsync(id);
        }

        public async Task<User> Update(User user)
        {
            _db.Users.Update(user);
            await _db.SaveChangesAsync();
            return user;
        }
    }
}
