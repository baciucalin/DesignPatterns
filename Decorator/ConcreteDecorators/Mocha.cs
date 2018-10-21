using Decorator.AbstractDecorators;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.ConcreteDecorators
{
    class Mocha : CondimentDecorator
    {
        private const double MOCHA_COST = 0.20;
        Beverage bev;

        public Mocha(Beverage beverage)
        {
            bev = beverage;
            Description = bev.Description + ", Mokka";
        }

        public override double cost()
        {
            return bev.cost() + MOCHA_COST;
        }

    }
}
