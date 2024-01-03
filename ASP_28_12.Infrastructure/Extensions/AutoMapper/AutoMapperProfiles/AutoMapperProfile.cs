using ASP_28_12.Application.Catalog.OrderApp;
using ASP_28_12.Application.Catalog.OrderApp.Request;
using ASP_28_12.Application.Catalog.OrderDetailsApp;
using ASP_28_12.Application.Catalog.OrderDetailsApp.Request;
using ASP_28_12.Application.Catalog.ProductApp;
using ASP_28_12.Application.Catalog.ProductApp.Request;
using ASP_28_12.Application.Catalog.UserApp;
using ASP_28_12.Application.Catalog.UserApp.Request;
using ASP_28_12.Domains.Entities;
using AutoMapper;

namespace ASP_28_12.Infrastructure.Extensions.AutoMapper.AutoMapperProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<ProductCreateRequest, Product>();
            CreateMap<ProductUpdateRequest, Product>();
            CreateMap<ProductPagingRequest, Product>();

            CreateMap<User, UserDto>();
            CreateMap<UserCreateRequest, User>();
            CreateMap<UserUpdateRequest, User>();
            CreateMap<UserPagingRequest, User>();

            CreateMap<Order, OrderDto>();
            CreateMap<OrderCreateRequest, Order>();
            CreateMap<OrderUpdateRequest, Order>();
            CreateMap<OrderPagingRequest, Order>();

            CreateMap<OrderDetails, OrderDetailsDto>();
            CreateMap<OrderDetailsCreateRequest, OrderDetails>();
            CreateMap<OrderDetailsUpdateRequest, OrderDetails>();
            CreateMap<OrderDetailsPagingRequest, OrderDetails>();


        }
    }
}
