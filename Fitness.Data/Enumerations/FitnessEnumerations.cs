using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Data.Enumerations
{
    public class FitnessEnumerations
    {
        public enum Intensity
        {
            Easy = 0,
            Medium,
            Hard,
            Pro
        }

        public enum Category
        {
            Chest = 0,
            Back,
            Legs,
            Abs,
            Cardio
        }

        public enum Style
        {
            Light = 0,
            Medium,
            Heavy,
            Crossfit
        }
    }
}
