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
        public User SetBy {get; set;} = null!;
        public int StudentId {get; set;}
        public User Student {get; set;} = null!;
        public int WorkoutId {get; set;}
        public Workout Workout {get; set;} = null!;
        public DateTime AssignedAt {get; set;}
        public ICollection<WorkoutHistory> WorkoutHistories {get; set;} = [];
    }
}