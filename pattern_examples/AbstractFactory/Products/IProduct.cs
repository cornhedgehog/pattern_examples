using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_examples.AbstractFactory.Products
{
    abstract class IProduct
    {
        abstract public void GetNutritionFacts(double grams);
    }
}
