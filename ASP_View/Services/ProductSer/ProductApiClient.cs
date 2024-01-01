using ASP_28_12.Application.Catalog.ProductApp.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.Entities;
using Microsoft.AspNetCore.WebUtilities;

namespace ASP_View.Services.ProductSer
{
    public class ProductApiClient : IProductApiClient
    {
        public HttpClient _httpClient;

        public ProductApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> CreateProduct(ProductCreateRequest productCreateRequest)
        {
            var result = await _httpClient.PostAsJsonAsync("api/product", productCreateRequest);
            return result.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteProduct(Guid id)
        {
            var result = await _httpClient.DeleteAsync($"api/product/{id}");
            return result.IsSuccessStatusCode;
        }

        public async Task<PagedList<Product>> GetProduct(ProductPagingRequest productPagingRequest)
        {
            var queryStringPara = new Dictionary<string, string>
            {
                ["pageNumber"] = productPagingRequest.PageNumber.ToString()
            };
            if (!string.IsNullOrEmpty(productPagingRequest.ProductName)) queryStringPara.Add("productname", productPagingRequest.ProductName);
            string url = QueryHelpers.AddQueryString("/api/product", queryStringPara);
            var result = await _httpClient.GetFromJsonAsync<PagedList<Product>>(url);
            return result;
        }

        public async Task<Product> GetProductDetails(string id)
        {
            var result = await _httpClient.GetFromJsonAsync<Product>($"/api/product/{id}");
            return result;
        }

        public async Task<bool> UpdateProduct(Guid id, ProductUpdateRequest productUpdateRequest)
        {
            var result = await _httpClient.PutAsJsonAsync($"/api/product/{id}", productUpdateRequest);
            return result.IsSuccessStatusCode;
        }
    }
}
