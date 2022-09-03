using Guide.DataAccess.Concrete.EntityFramework.Mappings;
using Guide.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Guide.DataAccess.Concrete.EntityFramework.Contexts
{
    public class GuideContext : DbContext
    {
        #region DbSet

        public DbSet<Aim> Aims { get; set; }
        public DbSet<AimCategory> AimCategories { get; set; }
        public DbSet<AimOperation> AimOperations { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseCategory> ExerciseCategories { get; set; }
        public DbSet<ExerciseOperation> ExerciseOperations { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new TaskMap());
            //modelBuilder.Configurations.Add(new TaskCategoryMap());
            modelBuilder.ApplyConfiguration(new AimMap());
            //modelBuilder.Configurations.Add(new AimOperationMap());
            //modelBuilder.Configurations.Add(new TaskOperationMap());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlServer"));
        }
    }
}
