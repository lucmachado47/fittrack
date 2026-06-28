using FitTrack.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitTrack.Infrastructure.Persistence.Configurations;

public class WorkoutHistoryConfiguration : IEntityTypeConfiguration<WorkoutHistory>
{
    public void Configure(EntityTypeBuilder<WorkoutHistory> builder)
    {
        builder.HasKey(wh => wh.Id);

        builder.Property(wh => wh.WorkoutDate)
            .IsRequired();

        builder.Property(wh => wh.Situation)
            .IsRequired();

        builder.Property(wh => wh.Observations)
            .HasMaxLength(1000);

        builder.Property(wh => wh.Duration)
            .IsRequired();

        builder.HasOne(wh => wh.StudentWorkout)
            .WithMany(sw => sw.WorkoutHistories)
            .HasForeignKey(wh => wh.StudentWorkoutId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}