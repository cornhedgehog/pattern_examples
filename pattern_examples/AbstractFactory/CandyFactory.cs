using pattern_examples.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExamples.AbstractFactory
{
    class CandyFactory: IFactory
    {      
        public override IProduct CreateProductA()
        {            
            return new ChocoCandy();
        }

        public override IProduct CreateProductB()
        {            
            return new VanillaCandy();
        }
    }
}
