using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitTrack.Domain.Entities
{
    public class StudentWorkout
    {
        public int Id {get; set;}
        public int SetById {get; set;}
        public required User SetBy {get; set;}
        public int StudentId {get; set;}
        public required User Student {get; set;}
        public int WorkoutId {get; set;}
        public required Workout Workout {get; set;}
        public DateTime AssignedAt {get; set;}
        public ICollection<WorkoutHistory> WorkoutHistories {get; set;} = [];
    }
}