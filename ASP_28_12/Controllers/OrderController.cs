
using ASP_28_12.Application.Catalog.OrderApp.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.Entities;
using ASP_28_12.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ASP_28_12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPaging([FromQuery] OrderPagingRequest request)
        {
            var pageList = await _orderRepository.GetAllPaging(request);

            var orderDtosByName = pageList.Items.Select(x => new Order()
            {
                ID = x.ID,
                UserID = x.UserID,
                TotalFee = x.TotalFee,
                Status = x.Status,
                OrderDate = DateTimeOffset.UtcNow
            });
            return Ok(new PagedList<Order>(orderDtosByName.ToList(),
                pageList.MetaData.TotalCount,
                pageList.MetaData.CurrentPage,
                pageList.MetaData.PageSize));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] OrderCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var order = await _orderRepository.Create(new Order()
            {
                ID = request.ID,
                UserID = request.UserID,
                TotalFee = request.TotalFee,
                Status = request.Status,
                OrderDate = DateTimeOffset.UtcNow

            });
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
            var orderUpdate = await _orderRepository.GetById(id);
            if (orderUpdate == null)
            {
                return NotFound($"{id} is not found");
            }
            orderUpdate.UserID = request.UserID;
            orderUpdate.TotalFee = request.TotalFee;
            orderUpdate.Status = request.Status;
            orderUpdate.OrderDate = DateTime.Now;

            var result = await _orderRepository.Update(orderUpdate);
            return Ok(new Order()
            {
                ID = result.ID,
                UserID = result.UserID,
                TotalFee = result.TotalFee,
                Status = result.Status,
                OrderDate = result.OrderDate
            });
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
            return Ok(new Order()
            {
                ID = result.ID,
                UserID = result.UserID,
                TotalFee = result.TotalFee,
                Status = result.Status,
                OrderDate = result.OrderDate
            });
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var order = await _orderRepository.GetById(id);
            if (order == null) return NotFound($"{id} is not found");

            await _orderRepository.Delete(order);
            return Ok(new Order()
            {
                ID = order.ID,
                UserID = order.UserID,
                TotalFee = order.TotalFee,
                Status = order.Status,
                OrderDate = order.OrderDate
            });
        }
    }
}
