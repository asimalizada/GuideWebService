using Guide.Entities.Concrete.Aims;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Guide.DataAccess.Concrete.EntityFramework.Mappings
{
    public class AimMap : IEntityTypeConfiguration<Aim>
    {
        public void Configure(EntityTypeBuilder<Aim> builder)
        {
            builder.ToTable("Aims");
            builder.HasKey(a => a.Id);
            //builder.Property(a => a.Id);

            //builder.Property(a => a.Id).ValueGeneratedNever();
            builder.Property(a => a.Id).ValueGeneratedOnAdd().IsRequired();

            builder.Property(a => a.Title).HasColumnName("Title");
            builder.Property(a => a.Description).HasColumnName("Description");
            builder.Property(a => a.CreateDate).HasColumnName("CreateDate");
            builder.Property(a => a.IsConvertedToExercise).HasColumnName("IsConvertedToTask");
            builder.Property(a => a.TimeCategoryId).HasColumnName("TimeCategoryId");
        }
    }
}
