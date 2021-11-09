using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Fitness.Data.Enumerations.FitnessEnumerations;

namespace Fitness.Models
{
    public class WorkoutEdit
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

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
