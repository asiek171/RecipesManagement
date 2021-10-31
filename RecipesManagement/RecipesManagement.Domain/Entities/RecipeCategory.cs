using RecipesManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesManagement.Domain.Entities
{
    public class RecipeCategory : AdiutableEntity
    {
        public string Value { get; set; }
        public ICollection<Recipe> Recipes { get; set; }

        public RecipeCategory()
        {
            this.Recipes = new List<Recipe>();
        }
    }
}
