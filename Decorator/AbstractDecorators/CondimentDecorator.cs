using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.AbstractDecorators
{
     abstract class CondimentDecorator : Beverage
    {
        public override String Description { get; set; }
    }
}
