using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitTrack.Domain.Entities
{
    public class WorkoutItem
    {
        public int Id {get; set;}
        public int WorkoutId {get; set;}
        public Workout Workout {get; set;} = null!;
        public int ExerciseId {get; set;}
        public Exercise Exercise {get; set;} = null!;
        public int Sets {get; set;}
        public int Reps {get; set;}
        public decimal Weight {get; set;}
        public int RestTime {get; set;}
        public int Order {get; set;}
    }
}