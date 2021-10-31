using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipesManagement.Persistance
{
    public class RecipeDbContext :DbContext
    {
        public RecipeDbContext(DbContextOptions<RecipeDbContext> options) : base()
        {

        }
    }
}
