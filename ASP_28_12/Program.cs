using ASP_28_12.Domains.EF;
using ASP_28_12.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ASP_28_12
{
    public class Program
    {
        public IConfiguration Configuration { get; set; }
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<FlowerDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString"));
            });
            builder.Services.AddTransient<IProductRepository, ProductRepository>();
            builder.Services.AddTransient<IUserRepository, UserRepository>();
            builder.Services.AddTransient<IOrderRepository, OrderRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
