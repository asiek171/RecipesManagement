using RecipesManagement.Domain.Common;
using RecipesManagement.Domain.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipesManagement.Domain.Entities
{
    public class Unit : AdiutableEntity
    {
        public int Value { get; set; }
        public TypeOfUnitEnum Type { get; set; }
    }
}
