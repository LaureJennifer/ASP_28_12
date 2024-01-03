namespace ASP_28_12.Application.Catalog.OrderDetailsApp.Request
{
    public class OrderDetailsCreateRequest
    {
        public Guid OrderDetailsID { get; set; }
        public Guid OrderID { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity { get; set; }

    }
}
