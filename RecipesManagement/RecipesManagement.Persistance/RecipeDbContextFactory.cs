using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesManagement.Persistance
{
    public class RecipeDbContextFactory : DesignTimeDbContextFactoryBase<RecipeDbContext>
    {
        protected override RecipeDbContext CreateNewInstance(DbContextOptions<RecipeDbContext> options)
        {
            return new RecipeDbContext(options);
        }
    }
}
