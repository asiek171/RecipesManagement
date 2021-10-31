using RecipesManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesManagement.Domain.Entities
{
    public class Tag : AdiutableEntity
    {
        public string Value { get; set; }
        public ICollection<Recipe> Recipes { get; set; }

        public Tag()
        {
            this.Recipes = new List<Recipe>();
        }
    }
}
