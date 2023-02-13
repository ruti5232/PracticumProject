using Microsoft.Extensions.DependencyInjection;
using PracticumProject.Repositories.Entities;
using PracticumProject.Repositories.Interfaces;
using PracticumProject.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticumProject.Repositories
{
    public static class Extensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IGenericRepository<User>, UserRepository>();
            services.AddScoped<IGenericRepository<Child>, ChildRepository>();   
            return services;
        }
    }
}
