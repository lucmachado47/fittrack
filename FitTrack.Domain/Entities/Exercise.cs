using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitTrack.Domain.Entities
{
    public class Exercise
    {
        public int Id {get; set;}
        public required string Name {get; set;}
        public required string Description {get; set;}
        public int MuscleGroupId {get; set;}
        public MuscleGroup MuscleGroup {get; set;} = null!;
        public ICollection<WorkoutItem> WorkoutItems {get; set;} = [];
        public ICollection<ExerciseEquipment> ExerciseEquipments {get; set;} = [];
    }
}