using ASP_28_12.Application.Catalog.OrderDetails;
using ASP_28_12.Application.Catalog.OrderDetails.Request;
using ASP_28_12.Application.ViewModels.Pagination;

namespace ASP_View.Services.OrderDetails
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
