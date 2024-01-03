using ASP_28_12.Application.Catalog.OrderDetailsApp.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.EF;
using ASP_28_12.Domains.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP_28_12.Repositories
{
    public class OrderDetailsRepository : IOrderDetailsRepository
    {
        private readonly FlowerDbContext _db;

        public OrderDetailsRepository(FlowerDbContext db)
        {
            _db = db;
        }

        public async Task<OrderDetails> Create(OrderDetails orderDetails)
        {
            await _db.OrderDetails.AddAsync(orderDetails);
            await _db.SaveChangesAsync();
            return orderDetails;
        }

        public async Task<OrderDetails> Delete(OrderDetails orderDetails)
        {
            _db.OrderDetails.Remove(orderDetails);
            await _db.SaveChangesAsync();
            return orderDetails;
        }

        public async Task<PagedList<OrderDetails>> GetAllPaging(OrderDetailsPagingRequest orderDetailsPagingRequest)
        {
            var query = _db.OrderDetails.Include(x => x.Order).Include(x => x.Product).AsQueryable();

            if (orderDetailsPagingRequest.OrderID != null)
            {
                query = query.Where(x => x.OrderID == orderDetailsPagingRequest.OrderID);
            }
            if (orderDetailsPagingRequest.ProductID != null)
            {
                query = query.Where(x => x.ProductID == orderDetailsPagingRequest.ProductID);
            }

            var count = await query.CountAsync();
            var data = await query.Skip((orderDetailsPagingRequest.PageNumber - 1) * orderDetailsPagingRequest.PageSize)
            .Take(orderDetailsPagingRequest.PageSize).ToListAsync();
            return new PagedList<OrderDetails>(data, count, orderDetailsPagingRequest.PageNumber, orderDetailsPagingRequest.PageSize);
        }

        public async Task<OrderDetails> GetById(Guid id)
        {
            return await _db.OrderDetails.FindAsync(id);
        }

        public async Task<OrderDetails> Update(OrderDetails orderDetails)
        {
            _db.OrderDetails.Update(orderDetails);
            await _db.SaveChangesAsync();
            return orderDetails;
        }

    }
}
