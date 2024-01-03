using ASP_28_12.Application.Catalog.OrderApp;

namespace ASP_28_12.Application.Catalog.UserApp
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Address { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public string UserName { get; set; }
       

        public string UrlImage { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
 //       public List<OrderDto> Orders { get; set; }
    }
}
