using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExamples.AbstractFactory.Products
{
    class CocoCookie: ICookie
    {
        private const double caloriesPer100g = 360;

        public CocoCookie()
        {
            Console.WriteLine("Coconut Cookie was baked");
        }

        public override void GetNutritionFacts(double grams)
        {
            Console.WriteLine("This amount of cookies is {0:N} cal", ((caloriesPer100g * grams) / 100));
        }
    }
}
