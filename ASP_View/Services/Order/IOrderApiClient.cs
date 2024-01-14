using ASP_28_12.Application.Catalog.Order;
using ASP_28_12.Application.Catalog.Order.Request;
using ASP_28_12.Application.ViewModels.Pagination;

namespace ASP_View.Services.Order
{
    public interface IOrderApiClient
    {
        Task<PagedList<OrderDto>> GetOrder(OrderPagingRequest orderPagingRequest);
        Task<OrderDto> GetOrderDetails(string id);

        Task<bool> CreateOrder(OrderCreateRequest orderCreateRequest);
        Task<bool> UpdateOrder(Guid id, OrderUpdateRequest orderUpdateRequest);

        Task<bool> DeleteOrder(Guid id);
    }
}
