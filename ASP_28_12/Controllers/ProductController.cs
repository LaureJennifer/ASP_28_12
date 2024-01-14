using ASP_28_12.Application.Catalog.Product.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.Entities;
using ASP_28_12.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProductDto = ASP_28_12.Application.Catalog.Product.ProductDto;

namespace ASP_28_12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPaging([FromQuery] ProductPagingRequest request)
        {
            var pageList = await _productRepository.GetAllPaging(request);

            var productDtos = _mapper.Map<List<ProductDto>>(pageList.Items);

            var pagedListDto = new PagedList<ProductDto>(productDtos,
                pageList.MetaData.TotalCount,
                pageList.MetaData.CurrentPage,
                pageList.MetaData.PageSize);

            return Ok(pagedListDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var productEntity = _mapper.Map<Product>(request);
            productEntity.CreatedDate = DateTime.Now;

            var createdProduct = await _productRepository.Create(productEntity);

            var productDto = _mapper.Map<ProductDto>(createdProduct);

            return CreatedAtAction(nameof(GetById), new { id = productDto.ID }, productDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] ProductUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var productEntity = await _productRepository.GetById(id);
            if (productEntity == null)
            {
                return NotFound($"{id} is not found");
            }

            _mapper.Map(request, productEntity);
            productEntity.CreatedDate = DateTime.Now;

            var updatedProduct = await _productRepository.Update(productEntity);

            var updatedProductDto = _mapper.Map<ProductDto>(updatedProduct);

            return Ok(updatedProductDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var productEntity = await _productRepository.GetById(id);
            if (productEntity == null)
            {
                return NotFound($"{id} is not found");
            }

            var productDto = _mapper.Map<ProductDto>(productEntity);

            return Ok(productDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var productEntity = await _productRepository.GetById(id);
            if (productEntity == null)
                return NotFound($"{id} is not found");

            await _productRepository.Delete(productEntity);

            var deletedProductDto = _mapper.Map<ProductDto>(productEntity);

            return Ok(deletedProductDto);
        }
    }
}
