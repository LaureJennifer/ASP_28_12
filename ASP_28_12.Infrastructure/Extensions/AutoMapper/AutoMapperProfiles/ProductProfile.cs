using ASP_28_12.Application.Catalog.ProductApp.Request;
using ASP_28_12.Application.Catalog.ProductApp;
using ASP_28_12.Domains.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_28_12.Infrastructure.Extensions.AutoMapper.AutoMapperProfiles
{
    public class ProductProfile :Profile
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
