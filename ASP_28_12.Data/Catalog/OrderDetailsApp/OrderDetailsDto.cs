using ASP_28_12.Application.Catalog.OrderApp;
using ASP_28_12.Application.Catalog.ProductApp;


namespace ASP_28_12.Application.Catalog.OrderDetailsApp
{
    public class OrderDetailsDto
    {
        public Guid OrderDetailsID { get; set; }
        public Guid OrderID { get; set; }
        public OrderDto Order { get; set; }
        public Guid ProductID { get; set; }
        public string ProductName { get; set; }
        public ProductDto Product { get; set; }
        public int Quantity { get; set; }

    }
}
