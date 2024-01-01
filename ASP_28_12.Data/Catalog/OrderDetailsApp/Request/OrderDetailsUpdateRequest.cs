using ASP_28_12.Domains.Entities;
using ASP_28_12.Domains.Enums;

namespace ASP_28_12.Application.Catalog.OrderDetailsApp.Request
{
    public class OrderDetailsUpdateRequest
    {
        public Guid OrderID { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity { get; set; }

    }
}
