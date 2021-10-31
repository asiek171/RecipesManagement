using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesManagement.Domain.Entities
{
    public class RecipeResource
    {
        public int Id { get; set; }
        public string Uri { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
