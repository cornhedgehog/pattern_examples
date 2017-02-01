using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExamples.AbstractFactory
{
    class VanillaCandy: ICandy
    {
        private const double caloriesPer100g = 480;

        public VanillaCandy()
        {
            Console.WriteLine("Vanilla Candy was made");
        }

        public override void GetNutritionFacts(double grams)
        {
            Console.WriteLine("This amount of cookies is {0:N} cal", ((caloriesPer100g * grams) / 100));
        }
    }
}
