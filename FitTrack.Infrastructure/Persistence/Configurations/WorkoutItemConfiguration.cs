using FitTrack.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitTrack.Infrastructure.Persistence.Configurations;

public class WorkoutItemConfiguration : IEntityTypeConfiguration<WorkoutItem>
{
    public void Configure(EntityTypeBuilder<WorkoutItem> builder)
    {
        builder.HasKey(wi => wi.Id);

        builder.Property(wi => wi.Sets)
            .IsRequired();

        builder.Property(wi => wi.Reps)
            .IsRequired();

        builder.Property(wi => wi.Weight)
            .HasPrecision(6, 2);

        builder.Property(wi => wi.RestTime)
            .IsRequired();

        builder.Property(wi => wi.Order)
            .IsRequired();

        builder.HasOne(wi => wi.Workout)
            .WithMany(w => w.WorkoutItems)
            .HasForeignKey(wi => wi.WorkoutId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(wi => wi.Exercise)
            .WithMany(e => e.WorkoutItems)
            .HasForeignKey(wi => wi.ExerciseId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}