using ASP_28_12.Application.Catalog.OrderDetailsApp;
using ASP_28_12.Application.Catalog.OrderDetailsApp.Request;
using ASP_28_12.Domains.Entities;
using AutoMapper;

namespace ASP_28_12.Infrastructure.Extensions.AutoMapper.AutoMapperProfiles
{
    public class OrderDetailsProfile : Profile
    {
        public OrderDetailsProfile()
        {
            CreateMap<OrderDetails, OrderDetailsDto>();
            CreateMap<OrderDetailsCreateRequest, OrderDetails>();
            CreateMap<OrderDetailsUpdateRequest, OrderDetails>();
            CreateMap<OrderDetailsPagingRequest, OrderDetails>();
        }
    }
}
