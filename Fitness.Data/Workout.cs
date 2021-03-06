using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Fitness.Data.Enumerations.FitnessEnumerations;

namespace Fitness.Data
{
    public class Workout
    {
        [Key]
        public int WorkoutId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Reps { get; set; }

        [Required]
        public string Sets { get; set; }

        [Required]
        public Intensity Intensity { get; set; }
    }
}
