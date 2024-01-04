using ASP_28_12.Application.Catalog.OrderDetailsApp.Request;
using ASP_28_12.Application.Catalog.OrderDetailsApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ASP_28_12.Domains.Entities;

namespace ASP_28_12.Infrastructure.Extensions.AutoMapper.AutoMapperProfiles
{
    public class OrderDetailsProfile: Profile
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
