using RecipesManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesManagement.Domain.Entities
{
    public class Recipe : AdiutableEntity
    {
        public string Title { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
        public string Description { get; set; }
        public ICollection<RecipeCategory> RecipeCategories { get; set; }
        public ICollection<Rate> Rates { get; set; }
        public ICollection<Tag> Tags { get; set; }
        public ICollection<RecipeResource> RecipeResources { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; }

        public Recipe()
        {
            this.Ingredients = new List<Ingredient>();
            this.RecipeCategories = new List<RecipeCategory>();
            this.Rates = new List<Rate>();
            this.Tags = new List<Tag>();
            this.RecipeResources = new List<RecipeResource>();
        }
    }
}
