using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Models
{
    public class WorkoutCreate
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least 2 characters.")]
        [MaxLength(100, ErrorMessage = "Chill that's way too long...")]
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
