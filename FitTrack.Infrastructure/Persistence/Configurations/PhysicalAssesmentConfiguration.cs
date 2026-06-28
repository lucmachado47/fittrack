using FitTrack.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitTrack.Infrastructure.Persistence.Configurations
{
    public class PhysicalAssessmentConfiguration : IEntityTypeConfiguration<PhysicalAssessment>
    {
        public void Configure(EntityTypeBuilder<PhysicalAssessment> builder)
        {
            builder.HasKey(pa => pa.Id);

            builder.Property(pa => pa.Weight)
                .IsRequired();

            builder.Property(pa => pa.Height)
                .IsRequired();

            builder.Property(pa => pa.BodyFat)
                .IsRequired();

            builder.Property(pa => pa.AssessmentDate)
                .IsRequired();
        }
    }

}