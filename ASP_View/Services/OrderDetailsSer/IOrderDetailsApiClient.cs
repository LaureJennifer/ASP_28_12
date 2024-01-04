using ASP_28_12.Application.Catalog.OrderDetailsApp;
using ASP_28_12.Application.Catalog.OrderDetailsApp.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.Entities;

namespace ASP_View.Services.OrderDetailsSer
{
    public interface IOrderDetailsApiClient
    {
        Task<PagedList<OrderDetailsDto>> GetOrderDetails(OrderDetailsPagingRequest orderDetailsPagingRequest);
        Task<OrderDetailsDto> GetDetails(string id);

        Task<bool> CreateOrderDetails(OrderDetailsCreateRequest orderDetailsCreateRequest);
        Task<bool> UpdateOrderDetails(Guid id, OrderDetailsUpdateRequest orderDetailsUpdateRequest);

        Task<bool> DeleteOrderDetails(Guid id);
    }
}
