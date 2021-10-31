using System.Collections.Generic;

namespace RecipesManagement.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}