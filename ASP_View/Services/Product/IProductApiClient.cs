using ASP_28_12.Application.Catalog.Product;
using ASP_28_12.Application.Catalog.Product.Request;
using ASP_28_12.Application.ViewModels.Pagination;

namespace ASP_View.Services.Product
{
    public interface IProductApiClient
    {
        Task<PagedList<ProductDto>> GetProduct(ProductPagingRequest productPagingRequest);
        Task<ProductDto> GetProductDetails(string id);

        Task<bool> CreateProduct(ProductCreateRequest productCreateRequest);
        Task<bool> UpdateProduct(Guid id, ProductUpdateRequest productUpdateRequest);

        Task<bool> DeleteProduct(Guid id);

    }
}
