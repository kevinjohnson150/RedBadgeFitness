using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Fitness.Data.Enumerations.FitnessEnumerations;

namespace Fitness.Models.RoutineModels
{
    public class RoutineCreate
    {
        [Required]
        public Intensity Intensity { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public Style Style { get; set; }

        public Guid RoutineId { get; set; }

        public string Name { get; set; }

        public Guid WorkoutId { get; set; }

        public Guid UserId { get; set; }
    }
}
