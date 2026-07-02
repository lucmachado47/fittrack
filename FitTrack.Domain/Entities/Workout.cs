using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitTrack.Domain.Entities
{
    public class Workout
    {
        public int Id {get; set;}
        public required string Name {get; set;}
        public required string Split {get; set;}
        public required string Description {get; set;}
        public int CreatedById {get; set;}
        public User CreatedBy {get; set;} = null!;
        public ICollection<StudentWorkout> StudentWorkouts {get; set;} = [];
        public ICollection<WorkoutItem> WorkoutItems {get; set;} = [];
    }
}