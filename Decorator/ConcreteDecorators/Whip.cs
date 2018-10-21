using Decorator.AbstractDecorators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ConcreteDecorators
{
    class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage b)
        {
            this.beverage = b;
            Description = b.Description + ", with Whip";
        }

        public override double cost()
        {
            return beverage.cost() + 0.10;
        }

        //public override string getDescription()
        //{
        //    return beverage.Description + ", with Whip";
        //}
    }
}
