using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class Beverage
    {
        public virtual String Description { get; set; } = "Initial drink";
        public abstract double cost();
    }
}
