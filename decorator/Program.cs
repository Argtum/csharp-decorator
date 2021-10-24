using System;
using decorator.Beverage.Coffee;
using decorator.Beverage.Tea;
using decorator.Condiment;

namespace decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Oolong tea = new Oolong();
            Lemon lemon = new Lemon(tea, 1);
            IceCubes drink = new IceCubes(lemon, 2);

            Console.WriteLine(drink.GetDescription() + " costs: " + drink.GetCost());
        }
    }
}