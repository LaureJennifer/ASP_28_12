﻿using ASP_28_12.Domains.Enums;

namespace ASP_28_12.Application.Catalog.Order.Request
{
    public class OrderUpdateRequest
    {
        public Guid UserID { get; set; }
        public DateTimeOffset OrderDate { get; set; }
        public int TotalFee { get; set; }
        public Status Status { get; set; }

    }
}
