using Decorator.AbstractDecorators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ConcreteDecorators
{
    class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage b)
        {
            this.beverage = b;
            Description = b.Description + ", Soy";
        }

        public override double cost()
        {
            return beverage.cost() + 0.15;
        }

        //public override string getDescription()
        //{
        //    return beverage.Description + ", Soy";
        //}
    }
}
