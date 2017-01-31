using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExamples.AbstractFactory
{
    class CandyFactory: IFactory
    {
        public override void GatherIngredients()
        {
            throw new NotImplementedException();
        }

        public override void Make()
        {
           boil();
        }

        public override void Pack()
        {
            throw new NotImplementedException();
        }

        private void boil() { }
    }
}
