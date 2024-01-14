using ASP_28_12.Application.Catalog.User.Request;
using ASP_28_12.Application.Login;
using ASP_28_12.Application.Register;
using ASP_28_12.Application.ViewModels.Pagination;
using ASP_28_12.Domains.EF;
using ASP_28_12.Domains.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ASP_28_12.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly FlowerDbContext _db;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<Role> _roleManager;
        private readonly IConfiguration _config;
        public UserRepository(FlowerDbContext dbcontext, UserManager<User> userManager,SignInManager<User> signInManager,RoleManager<Role> roleManager,IConfiguration config)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
            _db = dbcontext;
        }

        public async Task<string> Authencate(LoginRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user == null) return null;
            var result = await _signInManager.PasswordSignInAsync(user, request.Password,false,false);
            if (!result.Succeeded)
            {
                return null;
            }
            var roles = await _userManager.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.Name,user.UserName),
                new Claim(ClaimTypes.Role,string.Join(";",roles))
            };
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JwtSecurityKey"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["JwtIssuer"],
                _config["JwtIssuer"],
                claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<User> Create(User user)
        {
            await _db.Users.AddAsync(user);
            await _db.SaveChangesAsync();
            return user;
        }

        public async Task<User> Delete(User user)
        {
            _db.Users.Remove(user);
            await _db.SaveChangesAsync();
            return user;
        }

        public async Task<PagedList<User>> GetAllPaging(UserPagingRequest userPagingRequest)
        {
            var query = _db.Users.Include(x => x.Orders).AsQueryable();

            if (!string.IsNullOrEmpty(userPagingRequest.UserName))
            {
                query = query.Where(x => x.UserName.ToLower().Contains(userPagingRequest.UserName.ToLower()));
            }
            var count = await query.CountAsync();
            var data = await query.OrderByDescending(x => x.CreatedDate)
            .Skip((userPagingRequest.PageNumber - 1) * userPagingRequest.PageSize)
            .Take(userPagingRequest.PageSize).ToListAsync();
            return new PagedList<User>(data, count, userPagingRequest.PageNumber, userPagingRequest.PageSize);
        }

        public async Task<User> GetById(Guid id)
        {
            return await _db.Users.FindAsync(id);
        }

        public async Task<bool> Register(RegisterRequest request)
        {
            var user = new User()
            {
                UserName = request.UserName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                Address = request.Address,
                UrlImage = request.UrlImage,
                
            };
            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }

        public async Task<User> Update(User user)
        {
            _db.Users.Update(user);
            await _db.SaveChangesAsync();
            return user;
        }
    }
}
