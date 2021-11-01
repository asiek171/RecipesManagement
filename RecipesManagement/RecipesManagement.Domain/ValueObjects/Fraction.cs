using RecipesManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesManagement.Domain.ValueObjects
{
    public class Fraction : ValueObject
    {
        public int Integer { get; set; }
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public override string ToString()
        {
            return $"{Integer} {Numerator}/{Denominator}";
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Integer;
            yield return Numerator;
            yield return Denominator;
        }
    }
}
