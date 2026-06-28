using FitTrack.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitTrack.Infrastructure.Persistence.Configurations
{
    public class MuscleGroupConfiguration : IEntityTypeConfiguration<MuscleGroup>
    {
        public void Configure(EntityTypeBuilder<MuscleGroup> builder)
        {
            builder.HasKey(mg => mg.Id);

            builder.Property(mg => mg.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Configure unique constraint via an index
            builder.HasIndex(mg => mg.Name).IsUnique();
        }
    }
}