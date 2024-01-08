using ASP_28_12.Application.Catalog.UserApp;
using ASP_28_12.Application.Catalog.UserApp.Request;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.Entities;
using ASP_28_12.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ASP_28_12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;

        }
        [HttpGet]
        public async Task<IActionResult> GetAllPaging([FromQuery] UserPagingRequest request)
        {
            var pageList = await _userRepository.GetAllPaging(request);

            var userDtos = _mapper.Map<List<UserDto>>(pageList.Items);

            return Ok(new PagedList<UserDto>(userDtos.ToList(),
                pageList.MetaData.TotalCount,
                pageList.MetaData.CurrentPage,
                pageList.MetaData.PageSize));
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserCreateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var UserEntity = _mapper.Map<User>(request);
            UserEntity.CreatedDate = DateTime.Now;

            var createdUser = await _userRepository.Create(UserEntity);

            var productDto = _mapper.Map<UserDto>(createdUser);
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
            var userEntity = await _userRepository.GetById(id);
            if (userEntity == null)
            {
                return NotFound($"{id} is not found");
            }


            _mapper.Map(request, userEntity);
            userEntity.CreatedDate = DateTime.Now;

            var updatedUser = await _userRepository.Update(userEntity);

            var updatedUserDto = _mapper.Map<UserDto>(updatedUser);

            return Ok(updatedUserDto);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            var userEntity = await _userRepository.GetById(id);
            if (userEntity == null)
            {
                return NotFound($"{id} is not found");
            }
            var userDto = _mapper.Map<UserDto>(userEntity);

            return Ok(userDto);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            var userEntity = await _userRepository.GetById(id);
            if (userEntity == null) return NotFound($"{id} is not found");

            await _userRepository.Delete(userEntity);
            var deletedUserDto = _mapper.Map<UserDto>(userEntity);

            return Ok(deletedUserDto);
        }
    }
}
