using ASP_28_12.Application.ViewModels.Pagination;

namespace ASP_28_12.Application.Catalog.User.Request
{
    public class UserPagingRequest : PagingParameter
    {
        public string? UserName { get; set; }
    }
}
