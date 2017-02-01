using PatternExamples.AbstractFactory;
using PatternExamples.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstract factory example
            Console.WriteLine("Abstract Factory Example:");
            IFactory cookieFactory = new CookieFactory();
            ChocoCookie chocoCookie = (ChocoCookie) cookieFactory.CreateProductA();
            chocoCookie.GetNutritionFacts(100);
            CocoCookie cocoCookie = (CocoCookie) cookieFactory.CreateProductB();
            cocoCookie.GetNutritionFacts(100);
            
            IFactory candyFactory = new CandyFactory();
            ChocoCandy chocoCandy = (ChocoCandy) candyFactory.CreateProductA();
            chocoCandy.GetNutritionFacts(100);
            VanillaCandy vanillaCandy = (VanillaCandy) candyFactory.CreateProductB();
            vanillaCandy.GetNutritionFacts(100);
            

            Console.ReadKey();
        }
    }
}
