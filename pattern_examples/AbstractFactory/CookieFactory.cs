using pattern_examples.AbstractFactory.Products;
using PatternExamples.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExamples.AbstractFactory
{
    class CookieFactory : IFactory
    {
        public override IProduct CreateProductA()
        {            
            return new ChocoCookie(); ;
        }

        public override IProduct CreateProductB()
        {          
            return new CocoCookie();
        }        
    }
}
