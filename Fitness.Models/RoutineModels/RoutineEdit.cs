using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Fitness.Data.Enumerations.FitnessEnumerations;

namespace Fitness.Models.RoutineModels
{
   public class RoutineEdit
    {
        public Guid Id { get; set; }

        public Category Category { get; set; }

        public string Name { get; set; }
    }
}
