using Application.Activities;
using Application.Core;
using Learning.Data;
using Microsoft.EntityFrameworkCore;

namespace RestfulAPILearning.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {            
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();            

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            services.AddCors(opt => opt.AddPolicy("CorsPolicy", policy => {
                policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000");
            }));

            services.AddMediatR(cfg =>
                            cfg.RegisterServicesFromAssembly(typeof(List.Handler).Assembly)
                        );
            services.AddAutoMapper(typeof(MappingProfiles).Assembly);

            return services;
        }
    }
}
