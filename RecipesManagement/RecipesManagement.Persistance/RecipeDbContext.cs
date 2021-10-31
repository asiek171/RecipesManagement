using Microsoft.EntityFrameworkCore;
using RecipesManagement.Domain.Common;
using RecipesManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RecipesManagement.Persistance
{
    public class RecipeDbContext :DbContext
    {
        public RecipeDbContext(DbContextOptions<RecipeDbContext> options) : base()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AdiutableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = new User();
                        entry.Entity.Created = DateTime.Now;
                        entry.Entity.StatusId = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = new User();
                        entry.Entity.Modified = DateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = new User();
                        entry.Entity.Modified = DateTime.Now;
                        entry.Entity.InactivatedBy = new User();
                        entry.Entity.Inactivated = DateTime.Now;
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;

                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
