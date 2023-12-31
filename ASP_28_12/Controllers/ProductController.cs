using ASP_28_12.Application.Catalog.ProductApp.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.Entities;
using ASP_28_12.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ASP_28_12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPaging([FromQuery] ProductPagingRequest request)
        {
            var pageList = await _productRepository.GetAllPaging(request);

            var productDtosByName = pageList.Items.Select(x => new Product()
            {
                ID = x.ID,
                Name = x.Name,
                Price = x.Price,
                UrlImage = x.UrlImage,
                CreatedDate = DateTime.Now
            });
            return Ok(new PagedList<Product>(productDtosByName.ToList(),
                pageList.MetaData.TotalCount,
                pageList.MetaData.CurrentPage,
                pageList.MetaData.PageSize));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var product = await _productRepository.Create(new Product()
            {
                ID = request.ID,
                CreatedDate = DateTime.Now,
                Name = request.Name,
                Price = request.Price,
                UrlImage = request.UrlImage,
                

            });
            return CreatedAtAction(nameof(GetById), new { request.ID }, request);
        }
        [HttpPut]
        [Route("{id}")]

        public async Task<IActionResult> Update(Guid id, [FromBody] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var productUpdate = await _productRepository.GetById(id);
            if (productUpdate == null)
            {
                return NotFound($"{id} is not found");
            }
            productUpdate.Name = request.Name;
            productUpdate.Price = request.Price;
            productUpdate.CreatedDate = DateTime.Now;
            productUpdate.UrlImage = request.UrlImage;

            var result = await _productRepository.Update(productUpdate);
            return Ok(new Product()
            {
                Name = result.Name,
                CreatedDate = DateTimeOffset.Now,
                Price = result.Price,
                ID = result.ID,
                UrlImage= result.UrlImage,
            });
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var result = await _productRepository.GetById(id);
            if (result == null)
            {
                return NotFound($"{id} is not found");
            }
            return Ok(new Product()
            {
                Name = result.Name,
                CreatedDate = result.CreatedDate,
                Price = result.Price,
                ID = result.ID,
                UrlImage= result.UrlImage,
                
            });
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var product = await _productRepository.GetById(id);
            if (product == null) return NotFound($"{id} is not found");

            await _productRepository.Delete(product);
            return Ok(new Product()
            {
                Name = product.Name,
                CreatedDate = product.CreatedDate,
                Price = product.Price,
                ID = product.ID,
                UrlImage = product.UrlImage,
            });
        }

    }
}
