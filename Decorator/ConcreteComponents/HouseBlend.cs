using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ConcreteComponents
{
    class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "Coffee mixed in the house";
        }

        public override double cost()
        {
            return 0.89;
        }
    }
}
