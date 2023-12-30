using ASP_28_12.Application.Catalog.ProductApp.Request;
using ASP_28_12.Application.Catalog.UserApp.Request;
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
        private readonly IProductRepository _productService;

        public ProductController(IProductRepository productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPaging([FromQuery] ProductPagingRequest product)
        {
            var pageList = await _productService.GetAllPaging(product);

            var ProductDtosByName = pageList.Items.Select(x => new Product()
            {
                ID = x.ID,
                Name = x.Name,
                Price = x.Price,
                CreatedDate = DateTime.Now
            });
            return Ok(new PagedList<Product>(ProductDtosByName.ToList(),
                pageList.MetaData.TotalCount,
                pageList.MetaData.CurrentPage,
                pageList.MetaData.PageSize));
        }
        //public async Task<IActionResult> GetAll()
        //{
        //    var tasks = await _taskRepository.GetTasks();
        //    var taskDtos = tasks.Select(x => new TaskDto()
        //    {
        //        Status = x.Status,
        //        Priority = x.Priority,
        //        Name = x.Name,
        //        CreatedDate = x.CreatedDate,
        //        AssigneeId = x.AssigneeId,
        //        Id = x.Id,
        //    });
        //    return Ok(taskDtos);
        //}
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var task = await _productService.Create(new Product()
            {
                ID = request.ID,
                CreatedDate = DateTime.Now,
                Name = request.Name,
                Price = request.Price

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
            var productUpdate = await _productService.GetById(id);
            if (productUpdate == null)
            {
                return NotFound($"{id} is not found");
            }
            productUpdate.Name = request.Name;
            productUpdate.Price = request.Price;
            productUpdate.CreatedDate = DateTime.Now;

            var result = await _productService.Update(productUpdate);
            return Ok(new Product()
            {
                Name = result.Name,
                CreatedDate = DateTimeOffset.Now,
                Price = result.Price,
                ID = result.ID
            });
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var result = await _productService.GetById(id);
            if (result == null)
            {
                return NotFound($"{id} is not found");
            }
            return Ok(new Product()
            {
                Name = result.Name,
                CreatedDate = result.CreatedDate,
                Price = result.Price,
                ID = result.ID
            });
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var product = await _productService.GetById(id);
            if (product == null) return NotFound($"{id} is not found");

            await _productService.Delete(product);
            return Ok(new Product()
            {
                Name = product.Name,
                CreatedDate = product.CreatedDate,
                Price = product.Price,
                ID = product.ID
            });
        }

    }
}
