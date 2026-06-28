using FitTrack.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitTrack.Infrastructure.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
    {
        // Primary Key
        builder.HasKey(u => u.Id);

        // Properties
        builder.Property(u => u.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(u => u.CPF)
            .IsRequired()
            .HasMaxLength(11);

        builder.HasIndex(u => u.CPF)
            .IsUnique();

        builder.Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasIndex(u => u.Email)
            .IsUnique();

        builder.Property(u => u.PasswordHash)
            .IsRequired();

        builder.Property(u => u.Goal)
            .HasMaxLength(255);

        builder.Property(u => u.Role)
            .IsRequired();

        builder.Property(u => u.DateOfBirth)
            .IsRequired();

        builder.Property(u => u.RegistrationDate)
            .IsRequired();

        builder.Property(u => u.IsActive)
            .IsRequired();

        // Relationships

        builder.HasMany(u => u.PhysicalAssessments)
            .WithOne(pa => pa.Student)
            .HasForeignKey(pa => pa.StudentId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(u => u.AssignedWorkouts)
            .WithOne(sw => sw.SetBy)
            .HasForeignKey(sw => sw.SetById)
            .OnDelete(DeleteBehavior.NoAction);

        builder.HasMany(u => u.ReceivedWorkouts)
            .WithOne(sw => sw.Student)
            .HasForeignKey(sw => sw.StudentId)
            .OnDelete(DeleteBehavior.NoAction);
    }
    }
}