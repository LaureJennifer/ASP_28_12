using ASP_28_12.Application.Catalog.ProductApp.Request;
using ASP_28_12.Application.Catalog.UserApp.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.Entities;
using ASP_28_12.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ASP_28_12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllPaging([FromQuery] UserPagingRequest request)
        {
            var pageList = await _userRepository.GetAllPaging(request);

            var userDtosByName = pageList.Items.Select(x => new User()
            {
                Id = x.Id,
                UserName = x.UserName,
                UrlImage = x.UrlImage,
                Address = x.Address,
                PhoneNumber = x.PhoneNumber,
                Email = x.Email,
                CreatedDate = DateTime.Now
            });
            return Ok(new PagedList<User>(userDtosByName.ToList(),
                pageList.MetaData.TotalCount,
                pageList.MetaData.CurrentPage,
                pageList.MetaData.PageSize));
        }
    
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var user = await _userRepository.Create(new User()
            {
                Id = request.ID,
                UserName = request.UserName,
                UrlImage = request.UrlImage,
                Address = request.Address,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                CreatedDate = DateTime.Now

            });
            return CreatedAtAction(nameof(GetById), new { request.ID }, request);
        }
        [HttpPut]
        [Route("{id}")]

        public async Task<IActionResult> Update(Guid id, [FromBody] UserUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var userUpdate = await _userRepository.GetById(id);
            if (userUpdate == null)
            {
                return NotFound($"{id} is not found");
            }
            userUpdate.UserName = request.UserName;
            userUpdate.UrlImage = request.UrlImage;
            userUpdate.Address = request.Address;
            userUpdate.PhoneNumber = request.PhoneNumber;
            userUpdate.Email = request.Email;
            userUpdate.CreatedDate = DateTime.Now;

            var result = await _userRepository.Update(userUpdate);
            return Ok(new User()
            {
                UserName = result.UserName,
                UrlImage = result.UrlImage,
                CreatedDate = result.CreatedDate,
                Address = result.Address,
                PhoneNumber = result.PhoneNumber,
                Email = result.Email,
                Id = result.Id
            });
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var result = await _userRepository.GetById(id);
            if (result == null)
            {
                return NotFound($"{id} is not found");
            }
            return Ok(new User()
            {
                UserName = result.UserName,
                UrlImage = result.UrlImage,
                CreatedDate = result.CreatedDate,
                Address = result.Address,
                PhoneNumber = result.PhoneNumber,
                Email = result.Email,
                Id = result.Id
            });
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var user = await _userRepository.GetById(id);
            if (user == null) return NotFound($"{id} is not found");

            await _userRepository.Delete(user);
            return Ok(new User()
            {
                UserName = user.UserName,
                UrlImage = user.UrlImage,
                CreatedDate = user.CreatedDate,
                Address = user.Address,
                PhoneNumber = user.PhoneNumber,
                Email = user.Email,
                Id = user.Id
            });
        }
    }
}
