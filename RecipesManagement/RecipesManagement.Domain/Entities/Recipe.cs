using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesManagement.Domain.Entities
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public string Description { get; set; }
        public User CreatedBy { get; set; }
        public ICollection<RecipeCategory> RecipeCategories { get; set; }
        public ICollection<Rate> Rates { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<RecipeResource> RecipeResources { get; set; }
    }
}
