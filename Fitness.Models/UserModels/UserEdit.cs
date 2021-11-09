using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Fitness.Data.Enumerations.FitnessEnumerations;

namespace Fitness.Models.UserModels
{
   public class UserEdit
    {
        [Required]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        [Required]
        public Style Style { get; set; }
    }
}
