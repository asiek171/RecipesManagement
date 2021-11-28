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

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Rate> Rates { get; set; }
        public DbSet<RecipeCategory> RecipeCategories { get; set; }
        public DbSet<RecipeResource> RecipeResources { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.Entity<User>().OwnsOne(p => p.UserName);
            modelBuilder.Entity<Ingredient>().OwnsOne(p => p.Value);
        }

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
