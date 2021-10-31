using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesManagement.Domain.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
    }
}
