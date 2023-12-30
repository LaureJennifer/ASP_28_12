namespace ASP_28_12.Application.Catalog.UserApp.Request
{
    public class UserCreateRequest
    {
        public Guid ID { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string UrlImage { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        
    }
}
