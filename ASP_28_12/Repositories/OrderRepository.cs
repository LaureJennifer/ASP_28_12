using ASP_28_12.Application.Catalog.OrderApp.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.EF;
using ASP_28_12.Domains.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP_28_12.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly FlowerDbContext _db;

        public OrderRepository(FlowerDbContext db)
        {
            _db = db;
        }

        public async Task<Order> Create(Order order)
        {
            await _db.Orders.AddAsync(order);
            await _db.SaveChangesAsync();
            return order;
        }

        public async Task<Order> Delete(Order order)
        {
            _db.Orders.Remove(order);
            await _db.SaveChangesAsync();
            return order;
        }

        public async Task<PagedList<Order>> GetAllPaging(OrderPagingRequest orderPagingRequest)
        {
            var query = _db.Orders.Include(x => x.OrderDetails).Include(y=>y.User).AsQueryable();

            if (orderPagingRequest.UserID != null)
            {
                query = query.Where(x => x.UserID == orderPagingRequest.UserID);
            }
            var count = await query.CountAsync();
            var data = await query.OrderByDescending(x => x.OrderDate)
            .Skip((orderPagingRequest.PageNumber - 1) * orderPagingRequest.PageSize)
            .Take(orderPagingRequest.PageSize).ToListAsync();
            return new PagedList<Order>(data, count, orderPagingRequest.PageNumber, orderPagingRequest.PageSize);
        }

        public async Task<Order> GetById(Guid id)
        {
            // return await _db.Orders.Include(y => y.User).FirstAsync(x=>x.ID==id);
            return await _db.Orders.FindAsync(id);
        }

        public async Task<Order> Update(Order order)
        {
            _db.Orders.Update(order);
            await _db.SaveChangesAsync();
            return order;
        }
    }
}
