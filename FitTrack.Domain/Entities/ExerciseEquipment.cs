using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitTrack.Domain.Entities
{
    public class ExerciseEquipment
    {
        public int Id {get; set;}
        public int ExerciseId {get; set;}
        public required Exercise Exercise {get; set;}
        public int EquipmentId {get; set;}
        public required Equipment Equipment {get; set;}
        
    }
}