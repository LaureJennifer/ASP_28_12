using ASP_28_12.Domains.Enums;

namespace ASP_28_12.Domains.Entities
{
    public class Order
    {
        public Guid ID { get; set; }
        public Guid CustomerID { get; set; }
        public Guid UserID { get; set; }

        public User User { get; set; }
        public Customer Customer { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public int TotalFee { get; set; }
        public Status Status { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
    }
}
