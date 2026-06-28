using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitTrack.Domain.Entities
{
    public class WorkoutHistory
    {
        public int Id {get; set;}
        public int StudentWorkoutId {get; set;}
        public required StudentWorkout StudentWorkout {get; set;}
        public DateTime WorkoutDate {get; set;}
        public Enums.Situation Situation {get; set;}
        public required string Observations {get; set;}
        public TimeSpan Duration {get; set;}
    }
}