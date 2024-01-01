using ASP_28_12.Application.Catalog.OrderDetailsApp.Request;
using ASP_28_12.Application.Catalog.ProductApp.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.Entities;
using ASP_28_12.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP_28_12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IOrderDetailsRepository _orderDetailsRepository;

        public OrderDetailsController(IOrderDetailsRepository orderDetailsRepository)
        {
            _orderDetailsRepository = orderDetailsRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPaging([FromQuery] OrderDetailsPagingRequest request)
        {
            var pageList = await _orderDetailsRepository.GetAllPaging(request);

            var orderDetailsDtosByName = pageList.Items.Select(x => new OrderDetails()
            {
                OrderDetailsID = x.OrderDetailsID,
                ProductID = x.ProductID,
                OrderID = x.OrderID,
                Quantity = x.Quantity
            });
            return Ok(new PagedList<OrderDetails>(orderDetailsDtosByName.ToList(),
                pageList.MetaData.TotalCount,
                pageList.MetaData.CurrentPage,
                pageList.MetaData.PageSize));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] OrderDetailsCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var orderDetails = await _orderDetailsRepository.Create(new OrderDetails()
            {               
                ProductID = request.ProductID,
                OrderID = request.OrderID,
                Quantity = request.Quantity,
                 OrderDetailsID = request.OrderDetailsID
            });
            //return CreatedAtAction(nameof(GetById), new { request.OrderDetailsID }, request);
            return Ok(new OrderDetails()
            {
                ProductID = orderDetails.ProductID,
                OrderID = orderDetails.OrderID,
                Quantity = orderDetails.Quantity,
                OrderDetailsID = orderDetails.OrderDetailsID
            });
        }

        [HttpPut]
        [Route("{id}")]

        public async Task<IActionResult> Update(Guid id, [FromBody] OrderDetailsUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var orderDetailsUpdate = await _orderDetailsRepository.GetById(id);
            if (orderDetailsUpdate == null)
            {
                return NotFound($"{id} is not found");
            }
            orderDetailsUpdate.ProductID = request.ProductID;
            orderDetailsUpdate.OrderID = request.OrderID;
            orderDetailsUpdate.Quantity = request.Quantity;

            var result = await _orderDetailsRepository.Update(orderDetailsUpdate);
            return Ok(new OrderDetails()
            {
                OrderDetailsID = result.OrderDetailsID,
                ProductID = result.ProductID,
                OrderID = result.OrderID,
                Quantity = result.Quantity
            });
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
            return Ok(new OrderDetails()
            {
                OrderDetailsID = result.OrderDetailsID,
                ProductID = result.ProductID,
                OrderID = result.OrderID,
                Quantity = result.Quantity

            });
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var orderDetails = await _orderDetailsRepository.GetById(id);
            if (orderDetails == null) return NotFound($"{id} is not found");

            await _orderDetailsRepository.Delete(orderDetails);
            return Ok(new OrderDetails()
            {
                OrderDetailsID = orderDetails.OrderDetailsID,
                ProductID = orderDetails.ProductID,
                OrderID = orderDetails.OrderID,
                Quantity = orderDetails.Quantity
            });
        }
    }
}
