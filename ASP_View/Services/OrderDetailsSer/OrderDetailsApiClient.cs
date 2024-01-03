﻿using ASP_28_12.Application.Catalog.OrderDetailsApp.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.Entities;
using Microsoft.AspNetCore.WebUtilities;

namespace ASP_View.Services.OrderDetailsSer
{
    public class OrderDetailsApiClient : IOrderDetailsApiClient
    {
        public HttpClient _httpClient;

        public OrderDetailsApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<bool> CreateOrderDetails(OrderDetailsCreateRequest orderDetailsCreateRequest)
        {
            var result = await _httpClient.PostAsJsonAsync("api/orderdetails", orderDetailsCreateRequest);
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteOrderDetails(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"api/orderdetails/{id}");
            return result.IsSuccessStatusCode;
        }

        public async Task<OrderDetails> GetDetails(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<OrderDetails>($"/api/orderdetails/{id}");
            return result;
        }

        public async Task<PagedList<OrderDetails>> GetOrderDetails(OrderDetailsPagingRequest orderDetailsPagingRequest)
        {
            var queryStringPara = new Dictionary<string, string>
            {
                ["pageNumber"] = orderDetailsPagingRequest.PageNumber.ToString()
            };
            string querySearch = orderDetailsPagingRequest.ProductID.ToString();
            if (!string.IsNullOrEmpty(querySearch)) queryStringPara.Add("productid", orderDetailsPagingRequest.ProductID.ToString());
            string querySearchOrderID = orderDetailsPagingRequest.OrderID.ToString();

            if (!string.IsNullOrEmpty(querySearchOrderID)) queryStringPara.Add("orderid", orderDetailsPagingRequest.OrderID.ToString());

            string url = QueryHelpers.AddQueryString("/api/orderdetails", queryStringPara);
            var result = await _httpClient.GetFromJsonAsync<PagedList<OrderDetails>>(url);
            return result;
        }

        public async Task<bool> UpdateOrderDetails(Guid id, OrderDetailsUpdateRequest orderDetailsUpdateRequest)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/orderdetails/{id}", orderDetailsUpdateRequest);
            return result.IsSuccessStatusCode;
        }
    }
}
