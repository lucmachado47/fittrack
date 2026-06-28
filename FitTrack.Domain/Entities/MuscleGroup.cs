using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitTrack.Domain.Entities
{
    public class MuscleGroup
    {
        public int Id {get; set;}
        public required string Name {get; set;}
        public ICollection<Exercise> Exercises {get; set;} = [];

    }
}