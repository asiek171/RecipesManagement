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
        public string Value { get; set; }
        public string ValuePlural { get; set; }
        public TypeOfUnitEnum Type { get; set; }

    }
}
