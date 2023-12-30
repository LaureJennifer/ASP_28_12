using ASP_28_12.Application.Catalog.ProductApp.Request;
using ASP_28_12.Application.Catalog.UserApp.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.Entities;

namespace ASP_28_12.Repositories
{
    public interface IProductRepository
    {
        public Task<Product> Create(Product product);
        public Task<Product> Update(Product product);
        public Task<Product> Delete(Product product);
        public Task<Product> GetById(Guid id);
        public Task<PagedList<Product>> GetAllPaging(ProductPagingRequest productPagingRequest);

    }
}
