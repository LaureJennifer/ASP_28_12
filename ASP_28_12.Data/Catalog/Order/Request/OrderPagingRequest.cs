﻿using ASP_28_12.Application.ViewModels.Pagination;

namespace ASP_28_12.Application.Catalog.Order.Request
{
    public class OrderPagingRequest : PagingParameter
    {
        public Guid? UserID { get; set; }
    }
}