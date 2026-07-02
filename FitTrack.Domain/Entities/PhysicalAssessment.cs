using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitTrack.Domain.Entities
{
    public class PhysicalAssessment
    {
        public int Id {get; set;}
        public int StudentId {get; set;}
        public User Student {get; set;} = null!;
        public decimal Weight {get; set;}
        public decimal Height {get; set;}
        public decimal BodyFat {get; set;}
        public DateTime AssessmentDate {get; set;}

    }
}