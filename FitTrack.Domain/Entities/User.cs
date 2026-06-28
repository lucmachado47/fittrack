using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitTrack.Domain.Entities
{
    public class User
    {
        public int Id {get; set;}
        public required string Name {get; set;}
        public required string CPF {get; set;}
        public required DateTime DateOfBirth {get; set;}
        public required string Email {get; set;}
        public required DateTime RegistrationDate {get; set;}
        public required string PasswordHash {get; set;}
        public bool IsActive {get; set;}
        public required string Goal {get; set;}
        public Enums.Role Role {get; set;}
        public ICollection<PhysicalAssessment> PhysicalAssessments {get; set;} = [];
        public ICollection<StudentWorkout> AssignedWorkouts { get; set; } = [];
        public ICollection<StudentWorkout> ReceivedWorkouts { get; set; } = [];
        public ICollection<Workout> CreatedWorkouts { get; set; } = [];
    }
}