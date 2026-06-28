using FitTrack.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitTrack.Infrastructure.Persistence.Configurations
{
    public class ExerciseEquipmentConfiguration : IEntityTypeConfiguration<ExerciseEquipment>
    {
        public void Configure(EntityTypeBuilder<ExerciseEquipment> builder)
        {
            builder.HasKey(ee => new { ee.ExerciseId, ee.EquipmentId });

            builder.HasOne(ee => ee.Exercise)
                .WithMany(e => e.ExerciseEquipments)
                .HasForeignKey(ee => ee.ExerciseId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(ee => ee.Equipment)
                .WithMany(e => e.ExerciseEquipments)
                .HasForeignKey(ee => ee.EquipmentId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}