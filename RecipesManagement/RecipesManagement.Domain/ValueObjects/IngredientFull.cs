using RecipesManagement.Domain.Common;
using RecipesManagement.Domain.Common.Enums;
using RecipesManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipesManagement.Domain.ValueObjects
{
    public class IngredientFull : ValueObject
    {
        public Fraction Quantity { get; set; }
        public string Value { get; set; }
        public Unit Unit { get; set; }

        public override string ToString()
        {
            
            return $"{Quantity.ToString()} {Unit.Value} {Value}";
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Quantity;
            yield return Value;
            yield return Unit;
        }
    }
}
