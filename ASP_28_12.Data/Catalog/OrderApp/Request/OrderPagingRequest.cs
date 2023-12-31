using ASP_28_12.Application.ViewModels.Pagination;

namespace ASP_28_12.Application.Catalog.OrderApp.Request
{
    public class OrderDetailsPagingRequest : PagingParameter
    {
        public Guid? UserID { get; set; }
    }
}
