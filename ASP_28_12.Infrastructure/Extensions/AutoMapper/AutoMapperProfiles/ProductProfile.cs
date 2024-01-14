using ASP_28_12.Application.Catalog.Product;
using ASP_28_12.Application.Catalog.Product.Request;
using ASP_28_12.Domains.Entities;
using AutoMapper;

namespace ASP_28_12.Infrastructure.Extensions.AutoMapper.AutoMapperProfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<ProductCreateRequest, Product>();
            CreateMap<ProductUpdateRequest, Product>();
            CreateMap<ProductPagingRequest, Product>();
        }
    }
}
