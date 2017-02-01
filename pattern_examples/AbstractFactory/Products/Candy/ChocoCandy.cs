using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExamples.AbstractFactory
{
    class ChocoCandy: ICandy
    {
        private const double caloriesPer100g = 494;

        public ChocoCandy()
        {
            Console.WriteLine("Chocolate Candy was made");
        }

        public override void GetNutritionFacts(double grams)
        {
            Console.WriteLine("This amount of candies is {0:N} cal", ((caloriesPer100g * grams) / 100));
        }
    }
}
