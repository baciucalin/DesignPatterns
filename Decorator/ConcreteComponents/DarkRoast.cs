using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ConcreteComponents
{
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark roast";
        }

        public override double cost()
        {
            return 2.49;
        }
    }
}
