using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectWeightCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            WeightCalculatorClass weightCalculatorClass = new WeightCalculatorClass(180, 'm');
            WeightCalculatorClass weightCalculatorClass1 = new WeightCalculatorClass(162, 'f');

            double weight = weightCalculatorClass.GetIdealWeight();
            double weight1 = weightCalculatorClass1.GetIdealWeight();

            Console.WriteLine($"The ideal weight should be: {weight}");
            Console.WriteLine($"The ideal weight should be: {weight1}");

            Console.ReadKey();
        }
    }
}
