
using ASP_28_12.Application.Catalog.OrderApp;
using ASP_28_12.Application.Catalog.OrderApp.Request;
using ASP_28_12.Application.Catalog.UserApp;
using ASP_28_12.Application.Catalog.UserApp.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.EF;
using ASP_28_12.Domains.Entities;
using ASP_28_12.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ASP_28_12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;

        public OrderController(IOrderRepository orderRepository, IUserRepository userRepository,IMapper mapper)
        {
            _orderRepository = orderRepository;
            _userRepository = userRepository;
            _mapper = mapper;
            
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPaging([FromQuery] OrderPagingRequest request)
        {
            var pageList = await _orderRepository.GetAllPaging(request);
            var orderDtos = _mapper.Map<List<OrderDto>>(pageList.Items);

            foreach (var orderDto in orderDtos)
            {
                 //orderDto.UserName = orderDto.User?.UserName;
                orderDto.UserName = _userRepository.GetById(orderDto.UserID).Result.UserName;
            }
            return Ok(new PagedList<OrderDto>(orderDtos.ToList(),
                pageList.MetaData.TotalCount,
                pageList.MetaData.CurrentPage,
                pageList.MetaData.PageSize));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] OrderCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);  

            var orderEntity = _mapper.Map<Order>(request);

            var createdOrder = await _orderRepository.Create(orderEntity);

            var orderDto = _mapper.Map<OrderDto>(createdOrder); 
            return CreatedAtAction(nameof(GetById), new { request.ID }, request);
        }
        [HttpPut]
        [Route("{id}")]

        public async Task<IActionResult> Update(Guid id, [FromBody] OrderUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var orderEntity = await _orderRepository.GetById(id);
            if (orderEntity == null)
            {
                return NotFound($"{id} is not found");
            }


            _mapper.Map(request, orderEntity);
           

            var updatedOrder = await _orderRepository.Update(orderEntity);

            var updatedOrderDto = _mapper.Map<OrderDto>(updatedOrder);

            return Ok(updatedOrderDto);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var result = await _orderRepository.GetById(id);

            if (result == null)
            {
                return NotFound($"{id} is not found");
            }

            var orderDto = _mapper.Map<OrderDto>(result);
            orderDto.UserName = _userRepository.GetById(orderDto.UserID).Result.UserName;
            return Ok(orderDto);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var orderEntity = await _orderRepository.GetById(id);
            if (orderEntity == null) return NotFound($"{id} is not found");

            await _orderRepository.Delete(orderEntity);
            var deletedOrderDto = _mapper.Map<OrderDto>(orderEntity);

            return Ok(deletedOrderDto);
        }
    }
}
