using RecipesManagement.Domain.Common;
using RecipesManagement.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesManagement.Domain.Entities
{
    public class Ingredient : AdiutableEntity
    {
        public IngredientFull Value { get; set; }
    }
}
