using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Fitness.Data.Enumerations.FitnessEnumerations;

namespace Fitness.Models
{
    public class WorkoutListItem
    {
        public int WorkoutId { get; set; }

        public string Title { get; set; }

        public string Reps { get; set; }

        public string Sets { get; set; }

        public Intensity Intensity { get; set; }
    }
}
