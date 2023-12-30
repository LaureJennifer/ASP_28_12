using ASP_28_12.Application.ViewModels.Pagination;

namespace ASP_28_12.Application.Catalog.ProductApp.Request
{
    public class ProductPagingRequest : PagingParameter
    {
        public string? ProductName { get; set; }
    }
}
