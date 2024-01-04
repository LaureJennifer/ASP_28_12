using ASP_28_12.Application.Catalog.OrderApp;
using ASP_28_12.Application.Catalog.OrderDetailsApp;
using ASP_28_12.Application.Catalog.OrderDetailsApp.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.Entities;
using ASP_28_12.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ASP_28_12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IOrderDetailsRepository _orderDetailsRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public OrderDetailsController(IOrderDetailsRepository orderDetailsRepository, IOrderRepository orderRepository, IProductRepository productRepository, IMapper mapper)
        {
            _orderDetailsRepository = orderDetailsRepository;
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPaging([FromQuery] OrderDetailsPagingRequest request)
        {
            var pageList = await _orderDetailsRepository.GetAllPaging(request);

            var orderDetailsDtos = _mapper.Map<List<OrderDetailsDto>>(pageList.Items);

            foreach (var orderDetailDto in orderDetailsDtos)
            {
                orderDetailDto.ProductName = _productRepository.GetById(orderDetailDto.ProductID).Result.Name;
                orderDetailDto.Price = _productRepository.GetById(orderDetailDto.ProductID).Result.Price;

            }
            return Ok(new PagedList<OrderDetailsDto>(orderDetailsDtos.ToList(),
                pageList.MetaData.TotalCount,
                pageList.MetaData.CurrentPage,
                pageList.MetaData.PageSize));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] OrderDetailsCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var orderDetailsEntity = _mapper.Map<OrderDetails>(request);

            var createdOrderDetail = await _orderDetailsRepository.Create(orderDetailsEntity);

            var orderDetailsDto = _mapper.Map<OrderDetailsDto>(createdOrderDetail);
            orderDetailsDto.ProductName = _productRepository.GetById(orderDetailsDto.ProductID).Result.Name;
            orderDetailsDto.Price = _productRepository.GetById(orderDetailsDto.ProductID).Result.Price;
            return Ok(orderDetailsDto);
            //return CreatedAtAction(nameof(GetById), new { request.OrderDetailsID }, request);
           
        }

        [HttpPut]
        [Route("{id}")]

        public async Task<IActionResult> Update(Guid id, [FromBody] OrderDetailsUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var orderDetailsEntity = await _orderDetailsRepository.GetById(id);
            if (orderDetailsEntity == null)
            {
                return NotFound($"{id} is not found");
            }
            _mapper.Map(request, orderDetailsEntity);


            var updatedOrderDetails = await _orderDetailsRepository.Update(orderDetailsEntity);

            var updatedOrderDetailsDto = _mapper.Map<OrderDetailsDto>(updatedOrderDetails);
            updatedOrderDetailsDto.ProductName = _productRepository.GetById(updatedOrderDetailsDto.ProductID).Result.Name;
            updatedOrderDetailsDto.Price = _productRepository.GetById(updatedOrderDetailsDto.ProductID).Result.Price;
            return Ok(updatedOrderDetailsDto);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var result = await _orderDetailsRepository.GetById(id);
            if (result == null)
            {
                return NotFound($"{id} is not found");
            }
            var orderDetailsDto = _mapper.Map<OrderDetailsDto>(result);
            orderDetailsDto.ProductName = _productRepository.GetById(orderDetailsDto.ProductID).Result.Name;
            orderDetailsDto.Price = _productRepository.GetById(orderDetailsDto.ProductID).Result.Price;

            return Ok(orderDetailsDto);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var orderDetailsEntity = await _orderDetailsRepository.GetById(id);
            if (orderDetailsEntity == null) return NotFound($"{id} is not found");

            await _orderDetailsRepository.Delete(orderDetailsEntity);
            var deletedOrderDetailsDto = _mapper.Map<OrderDetailsDto>(orderDetailsEntity);
            deletedOrderDetailsDto.ProductName = _productRepository.GetById(deletedOrderDetailsDto.ProductID).Result.Name;
            deletedOrderDetailsDto.Price = _productRepository.GetById(deletedOrderDetailsDto.ProductID).Result.Price;
            return Ok(deletedOrderDetailsDto);
        }
    }
}
