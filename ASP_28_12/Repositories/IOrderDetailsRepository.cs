using ASP_28_12.Application.Catalog.OrderDetails.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.Entities;

namespace ASP_28_12.Repositories
{
    public interface IOrderDetailsRepository
    {
        public Task<OrderDetails> Create(OrderDetails orderDetails);
        public Task<OrderDetails> Update(OrderDetails orderDetails);
        public Task<OrderDetails> Delete(OrderDetails orderDetails);
        public Task<OrderDetails> GetById(Guid id);
        public Task<PagedList<OrderDetails>> GetAllPaging(OrderDetailsPagingRequest orderPagingRequest);
    }
}
