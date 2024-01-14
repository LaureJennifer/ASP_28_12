using ASP_28_12.Application.Catalog.Order;
using ASP_28_12.Application.Catalog.Order.Request;
using ASP_28_12.Domains.Entities;
using AutoMapper;

namespace ASP_28_12.Infrastructure.Extensions.AutoMapper.AutoMapperProfiles
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<Order, OrderDto>();
            CreateMap<OrderCreateRequest, Order>();
            CreateMap<OrderUpdateRequest, Order>();
            CreateMap<OrderPagingRequest, Order>();
        }
    }
}
