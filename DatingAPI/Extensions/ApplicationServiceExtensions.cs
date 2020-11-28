using AutoMapper;
using DatingAPI.Data;
using DatingAPI.Helpers;
using DatingAPI.Interfaces;
using DatingAPI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAPI.Extensions
{
    public static class ApplicationServiceExtensions
    {
       public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            services.AddDbContext<DataContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("MvcMovieContext")));

            return services;
        }
    }
}
