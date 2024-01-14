using ASP_28_12.Application.ViewModels.Pagination;

namespace ASP_28_12.Application.Catalog.OrderDetails.Request
{
    public class OrderDetailsPagingRequest : PagingParameter
    {
        public Guid? ProductID { get; set; }
        public Guid? OrderID { get; set; }

    }
}
