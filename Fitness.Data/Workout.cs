using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Data
{
    public class Workout
    {
        [Key]
        public int WorkoutId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Reps { get; set; }

        [Required]
        public string Sets { get; set; }

        public enum Intensity 
        { 
            Easy, 
            Medium,
            Hard,
            Pro
        }
    }
}
