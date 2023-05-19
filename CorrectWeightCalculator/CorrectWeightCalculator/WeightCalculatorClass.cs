using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectWeightCalculator
{
    class WeightCalculatorClass
    {
        private double Height { get; set; }

        private char Sex { get; set; }

        public WeightCalculatorClass(double Height, char Sex)
        {
            this.Height = Height;
            this.Sex = Sex;
        }

        public double GetIdealWeight()
        {
            if (Sex == 'm')
            {
                return (Height - 100) - ((Height - 150) / 4);
            }
            else if (Sex == 'f')
            {
                return (Height - 100) - ((Height - 150) / 2);
            }
            else
            {
                return 0;
            }
        }
    }
}
