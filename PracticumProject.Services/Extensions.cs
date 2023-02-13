using Microsoft.Extensions.DependencyInjection;
using PracticumProject.Common.DTOs;
using PracticumProject.Context;
using PracticumProject.Repositories;
using PracticumProject.Repositories.Interfaces;
using PracticumProject.Services.Interfaces;
using PracticumProject.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumProject.Services
{
    public static  class Extensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IGenericService<UserDTO>, UserService>();
            services.AddScoped<IGenericService<ChildDTO>, ChildService>();
            services.AddAutoMapper(typeof(Mapping));
            services.AddDbContext<IContext, DataContext>();
            return services;
        }
    }
}
