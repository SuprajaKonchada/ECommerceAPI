using ECommerceAPI.Data;
using ECommerceAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<ECommerceDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("ECommerceDbConnection")));
            // Register services with their respective lifetimes
            builder.Services.AddTransient<IProductService, ProductService>(); // Transient
            builder.Services.AddScoped<IOrderService, OrderService>(); // Scoped
            builder.Services.AddSingleton<IUserSessionService, UserSessionService>(); // Singleton
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
