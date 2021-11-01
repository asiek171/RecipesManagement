using System;
using System.Collections.Generic;
using System.Text;

namespace RecipesManagement.Domain.ValueObjects
{
    public class Ingredient
    {
        public Fraction Quantity { get; set; }
        public string Value { get; set; }
        public int Unit { get; set; }
    }
}
