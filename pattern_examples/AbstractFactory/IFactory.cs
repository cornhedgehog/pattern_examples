using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExamples.AbstractFactory
{
    abstract class IFactory
    {
        abstract public void GatherIngredients();
        abstract public void Make();
        abstract public void Pack();
    }
}
