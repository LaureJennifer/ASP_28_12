using ASP_28_12.Application.Catalog.OrderApp.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.Entities;

namespace ASP_View.Services.OrderSer
{
    public interface IOrderApiClient
    {
        Task<PagedList<Order>> GetOrder(OrderPagingRequest orderPagingRequest);
        Task<Order> GetOrderDetails(string id);

        Task<bool> CreateOrder(OrderCreateRequest orderCreateRequest);
        Task<bool> UpdateOrder(Guid id, OrderUpdateRequest orderUpdateRequest);

        Task<bool> DeleteOrder(Guid id);
    }
}
