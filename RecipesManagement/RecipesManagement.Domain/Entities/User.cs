using RecipesManagement.Domain.Common;
using RecipesManagement.Domain.ValueObjects;
using System.Collections.Generic;

namespace RecipesManagement.Domain.Entities
{
    public class User : AdiutableEntity
    {
        public PersonName UserName { get; set; }
        public string UniqueUserName { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
        public ICollection<Comment> Comments { get; set; }

        public User()
        {
            this.Recipes = new List<Recipe>();
            this.Comments = new List<Comment>();
        }
    }
}