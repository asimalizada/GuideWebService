using Guide.DataAccess.Concrete.EntityFramework.Mappings;
using Guide.Entities.Concrete.Aims;
using Guide.Entities.Concrete.Exercises;
using Microsoft.EntityFrameworkCore;

namespace Guide.DataAccess.Concrete.EntityFramework.Contexts
{
    public class GuideContext : DbContext
    {
        #region DbSet

        public DbSet<Aim> Aims { get; set; }
        public DbSet<AimProperty> AimProperties { get; set; }
        public DbSet<AimOperation> AimOperations { get; set; }
        public DbSet<AimPropertyOption> AimPropertyOptions { get; set; }
        public DbSet<AimPropertyValue> AimPropertyValues { get; set; }

        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseProperty> ExerciseProperties { get; set; }
        public DbSet<ExerciseOperation> ExerciseOperations { get; set; }
        public DbSet<ExercisePropertyOption> ExercisePropertyOptions { get; set; }
        public DbSet<ExercisePropertyValue> ExercisePropertyValues { get; set; }

        #endregion

        public GuideContext()
        {

        }

        public GuideContext(DbContextOptions<GuideContext> options) : base(options)
        {

        }

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
            optionsBuilder.UseSqlServer(@"server = (localdb)\MSSQLLocalDB; Database = GuideDb; Trusted_connection = true");
        }
    }
}
