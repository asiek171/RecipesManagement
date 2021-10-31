using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesManagement.Domain.Entities
{
    public class Rate
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public int RatedById { get; set; }
        public User RatedBy { get; set; }
    }
}
