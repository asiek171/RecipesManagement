using RecipesManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipesManagement.Domain.Common
{
    public class AdiutableEntity
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? Modified { get; set; }
        public int StatusId { get; set; }
        public string InactivatedBy { get; set; }
        public DateTime? Inactivated { get; set; }
    }
}
