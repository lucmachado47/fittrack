using FitTrack.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitTrack.Infrastructure.Persistence.Configurations;

public class WorkoutConfiguration : IEntityTypeConfiguration<Workout>
{
    public void Configure(EntityTypeBuilder<Workout> builder)
    {
        builder.HasKey(w => w.Id);

        builder.Property(w => w.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(w => w.Split)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(w => w.Description)
            .IsRequired()
            .HasMaxLength(500);

        builder.HasOne(w => w.CreatedBy)
            .WithMany(u => u.CreatedWorkouts)
            .HasForeignKey(w => w.CreatedById)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(w => w.WorkoutItems)
            .WithOne(wi => wi.Workout)
            .HasForeignKey(wi => wi.WorkoutId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(w => w.StudentWorkouts)
            .WithOne(sw => sw.Workout)
            .HasForeignKey(sw => sw.WorkoutId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}