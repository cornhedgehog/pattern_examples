﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExamples.AbstractFactory
{
    class VanillaCandy: ICandy
    {
        public override void Create()
        {
        }

        public String GetNutritionFacts()
        {            
            return String.Empty;
        }
    }
}
