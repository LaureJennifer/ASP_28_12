using ASP_28_12.Application.Catalog.ProductApp.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.Entities;

namespace ASP_View.Services.ProductSer
{
    public interface IProductApiClient
    {
        Task<PagedList<Product>> GetProduct(ProductPagingRequest productPagingRequest);
        Task<Product> GetProductDetails(string id);

        Task<bool> CreateProduct(ProductCreateRequest productCreateRequest);
        Task<bool> UpdateProduct(Guid id, ProductUpdateRequest productUpdateRequest);

        Task<bool> DeleteProduct(Guid id);

    }
}
