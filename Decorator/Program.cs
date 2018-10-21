using Decorator.ConcreteComponents;
using Decorator.ConcreteDecorators;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Beverage espresso = new Espresso();
            Console.WriteLine(espresso.Description + " costs: " + espresso.cost());

            Beverage beverage = new DarkRoast();
            Console.WriteLine(beverage.Description + " costs: " + beverage.cost());
            beverage = new Mocha(beverage);
            Console.WriteLine(beverage.Description + " costs: " + beverage.cost());
            beverage = new Soy(beverage);
            Console.WriteLine(beverage.Description + " costs: " + beverage.cost());
            beverage = new Whip(beverage);
            Console.WriteLine(beverage.Description + " costs: " + beverage.cost());
           
            Console.ReadLine();
        }
    }
}
