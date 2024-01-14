namespace ASP_28_12.Application.Catalog.OrderDetails.Request
{
    public class OrderDetailsUpdateRequest
    {
        public Guid OrderID { get; set; }
        public Guid ProductID { get; set; }
        public int Quantity { get; set; }

    }
}
