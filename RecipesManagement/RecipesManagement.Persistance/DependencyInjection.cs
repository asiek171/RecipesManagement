using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore; 
using System;

namespace RecipesManagement.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RecipeDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("RecipesDb")));

            return services;
        }
    }
}
