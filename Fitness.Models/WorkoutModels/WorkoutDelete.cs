﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Models
{
    public class WorkoutDelete
    {
        [Required]
        public Guid Id { get; set; }
    }
}
