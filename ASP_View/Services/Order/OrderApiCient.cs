﻿using ASP_28_12.Application.Catalog.Order;
using ASP_28_12.Application.Catalog.Order.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using Microsoft.AspNetCore.WebUtilities;

namespace ASP_View.Services.Order
{
    public class OrderApiClient : IOrderApiClient
    {
        public HttpClient _httpClient;

        public OrderApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<bool> CreateOrder(OrderCreateRequest orderCreateRequest)
        {
            var result = await _httpClient.PostAsJsonAsync("api/order", orderCreateRequest);
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteOrder(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"api/order/{id}");
            return result.IsSuccessStatusCode;
        }

        public async Task<PagedList<OrderDto>> GetOrder(OrderPagingRequest orderPagingRequest)
        {
            var queryStringPara = new Dictionary<string, string>
            {
                ["pageNumber"] = orderPagingRequest.PageNumber.ToString()
            };
            string querySearch = orderPagingRequest.UserID.ToString();
            if (!string.IsNullOrEmpty(querySearch)) queryStringPara.Add("userid", orderPagingRequest.UserID.ToString());
            string url = QueryHelpers.AddQueryString("/api/order", queryStringPara);
            var result = await _httpClient.GetFromJsonAsync<PagedList<OrderDto>>(url);
            return result;
        }

        public async Task<OrderDto> GetOrderDetails(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<OrderDto>($"/api/order/{id}");
            return result;
        }

        public async Task<bool> UpdateOrder(Guid id, OrderUpdateRequest orderUpdateRequest)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/order/{id}", orderUpdateRequest);
            return result.IsSuccessStatusCode;
        }
    }
}
