using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Fitness.Data.Enumerations.FitnessEnumerations;

namespace Fitness.Data
{
    public class Routine
    {
        [Key]
        public Guid RoutineId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public Category Category { get; set; }

        public Style Style { get; set; }

        public Intensity Intensity { get; set; }

       
        public Guid WorkoutId { get; set; }

        
        public Guid UserID { get; set; }
    }
}
