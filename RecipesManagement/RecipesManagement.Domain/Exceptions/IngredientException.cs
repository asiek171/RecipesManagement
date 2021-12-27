using RecipesManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesManagement.Domain.Exceptions
{
    public class IngredientException : Exception
    {
        public IngredientException(Ingredient ingredient, Exception ex) : base($"Value for /{ingredient.Value.Unit}/ is invalid", ex)
        {

        }
    }
}
