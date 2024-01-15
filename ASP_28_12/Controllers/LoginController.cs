using ASP_28_12.Application.Login;
using ASP_28_12.Application.Register;
using ASP_28_12.Domains.Entities;
using ASP_28_12.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ASP_28_12.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly IUserRepository _userRepository;
        private readonly RoleManager<Role> _roleManager;

        public LoginController(IConfiguration configuration,UserManager<User> userManager,SignInManager<User> signInManager, RoleManager<Role> roleManager, IUserRepository userRepository)
        {
            _configuration = configuration;
            _signInManager = signInManager;
            _userManager = userManager;
            _userRepository = userRepository;
            _roleManager = roleManager;
    }
        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody] LoginRequest login)
        {
            var user = await _userManager.FindByNameAsync(login.UserName);
            if (user == null) return BadRequest(new LoginResponse { Successful = false, Error = "Username and password are invalid." });

            var result = await _signInManager.PasswordSignInAsync(login.UserName, login.Password, false, false);

            if (!result.Succeeded) return BadRequest(new LoginResponse { Successful = false, Error = "Username and password are invalid." });
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, login.UserName),
                new Claim("UserId", user.Id.ToString()),
                 new Claim(ClaimTypes.Role,string.Join(";",roles))
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtSecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiry = DateTime.Now.AddDays(Convert.ToInt32(_configuration["JwtExpiryInDays"]));

            var token = new JwtSecurityToken(
                _configuration["JwtIssuer"],
                _configuration["JwtAudience"],
                claims,
                expires: expiry,
                signingCredentials: creds
            );

            return Ok(new LoginResponse { Successful = true, Token = new JwtSecurityTokenHandler().WriteToken(token) });
        }
        //[HttpPost("authenticate")]
        //[AllowAnonymous]
        //public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        //{
        //    var user = await _userManager.FindByNameAsync(loginRequest.UserName);
        //    if (!ModelState.IsValid) return BadRequest(ModelState);

        //    var resultToken = await _userRepository.Authencate(loginRequest);
        //    if (resultToken == null) return BadRequest(new LoginResponse { Successful = false, Error = "Username and password are invalid." });

        //    return Ok(new LoginResponse { Successful = true, Token = resultToken });

        //}
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromForm] RegisterRequest registerRequest)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var result = await _userRepository.Register(registerRequest);
            if (!result)
            {
                return BadRequest("Register is unsuccessful");
            }
            return Ok();
        }
    }
}
