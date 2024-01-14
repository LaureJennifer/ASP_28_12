using ASP_28_12.Application.Catalog.Product.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.EF;
using ASP_28_12.Domains.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP_28_12.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly FlowerDbContext _db;
        public ProductRepository(FlowerDbContext flowerDbContext)
        {
            _db = flowerDbContext;
        }

        public async Task<Product> Create(Product product)
        {
            await _db.Products.AddAsync(product);
            await _db.SaveChangesAsync();
            return product;
        }

        public async Task<Product> Delete(Product product)
        {
            _db.Products.Remove(product);
            await _db.SaveChangesAsync();
            return product;
        }

        public async Task<PagedList<Product>> GetAllPaging(ProductPagingRequest productPagingRequest)
        {
            var query = _db.Products.Include(x => x.OrderDetails).AsQueryable();

            if (!string.IsNullOrEmpty(productPagingRequest.ProductName))
            {
                query = query.Where(x => x.Name.ToLower().Contains(productPagingRequest.ProductName.ToLower()));
            }
            var count = await query.CountAsync();
            var data = await query.OrderByDescending(x => x.CreatedDate)
                .Skip((productPagingRequest.PageNumber - 1) * productPagingRequest.PageSize)
                .Take(productPagingRequest.PageSize).ToListAsync();
            return new PagedList<Product>(data, count, productPagingRequest.PageNumber, productPagingRequest.PageSize);

        }

        public async Task<Product> GetById(Guid id)
        {
            return await _db.Products.FindAsync(id);
        }

        public async Task<Product> Update(Product product)
        {
            _db.Products.Update(product);
            await _db.SaveChangesAsync();
            return product;
        }
    }
}
