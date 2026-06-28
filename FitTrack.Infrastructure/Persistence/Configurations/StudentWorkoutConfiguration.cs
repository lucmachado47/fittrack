using FitTrack.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitTrack.Infrastructure.Persistence.Configurations
{
    public class StudentWorkoutConfiguration : IEntityTypeConfiguration<StudentWorkout>
    {
        public void Configure(EntityTypeBuilder<StudentWorkout> builder)
    {
        builder.HasKey(sw => sw.Id);

        builder.Property(sw => sw.AssignedAt)
            .IsRequired();

        builder.HasOne(sw => sw.SetBy)
            .WithMany(u => u.AssignedWorkouts)
            .HasForeignKey(sw => sw.SetById)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(sw => sw.Student)
            .WithMany(u => u.ReceivedWorkouts)
            .HasForeignKey(sw => sw.StudentId)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(sw => sw.Workout)
            .WithMany(w => w.StudentWorkouts)
            .HasForeignKey(sw => sw.WorkoutId)
            .OnDelete(DeleteBehavior.Cascade);
    }
    }
}