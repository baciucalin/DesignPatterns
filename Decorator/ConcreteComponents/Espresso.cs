using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ConcreteComponents
{
    class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "The classic espresso";
        }

        public override double cost()
        {
            return 1.99;
        }
    }
}
