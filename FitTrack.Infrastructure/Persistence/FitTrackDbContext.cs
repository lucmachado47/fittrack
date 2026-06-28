using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FitTrack.Domain.Entities;

namespace FitTrack.Infrastructure.Persistence
{
    
    public class FitTrackDbContext : DbContext
    {
        public FitTrackDbContext(DbContextOptions<FitTrackDbContext> options) : base(options)
        {
        }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<ExerciseEquipment> ExerciseEquipments { get; set; }
        public DbSet<MuscleGroup> MuscleGroups { get; set; }
        public DbSet<PhysicalAssessment> PhysicalAssessments { get; set; }
        public DbSet<StudentWorkout> StudentWorkouts { get; set; }
        public DbSet<WorkoutHistory> WorkoutHistory { get; set; }
        public DbSet<WorkoutItem> WorkoutItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FitTrackDbContext).Assembly);
        }
    
    }
}