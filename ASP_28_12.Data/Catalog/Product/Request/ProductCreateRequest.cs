namespace ASP_28_12.Application.Catalog.Product.Request
{
    public class ProductCreateRequest
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string UrlImage { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}
