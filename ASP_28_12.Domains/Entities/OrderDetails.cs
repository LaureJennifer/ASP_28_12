namespace ASP_28_12.Domains.Entities
{
    public class OrderDetails
    {
        public Guid OrderDetailsID {  get; set; } 
        public Guid OrderID { get; set; }
        public Order Order { get; set; }
        public Guid ProductID { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }

    }
}
