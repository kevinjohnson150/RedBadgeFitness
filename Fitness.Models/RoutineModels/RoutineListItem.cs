using Fitness.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Fitness.Data.Enumerations.FitnessEnumerations;

namespace Fitness.Models.RoutineModels
{
   public class RoutineListItem
    {
        public Guid RoutineId { get; set; }

        public string Name { get; set; }

        public Category Category { get; set; }

    }
}
