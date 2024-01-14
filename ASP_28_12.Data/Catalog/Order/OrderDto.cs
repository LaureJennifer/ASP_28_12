using ASP_28_12.Domains.Enums;

namespace ASP_28_12.Application.Catalog.Order
{
    public class OrderDto
    {
        public Guid ID { get; set; }
        public Guid UserID { get; set; }
        //      public UserDto User { get; set; }
        public string UserName { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public int TotalFee { get; set; }
        public Status Status { get; set; }
        //public List<OrderDetailsDto> OrderDetails { get; set; }
    }
}
