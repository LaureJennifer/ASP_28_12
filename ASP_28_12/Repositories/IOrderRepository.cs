using ASP_28_12.Application.Catalog.OrderApp.Request;
using ASP_28_12.Application.Catalog.OrderDetailsApp.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.Entities;

namespace ASP_28_12.Repositories
{
    public interface IOrderRepository
    {
        public Task<Order> Create(Order order);
        public Task<Order> Update(Order order);
        public Task<Order> Delete(Order order);
        public Task<Order> GetById(Guid id);
        public Task<PagedList<Order>> GetAllPaging(OrderPagingRequest orderPagingRequest);
    }
}
