using decorator.Beverage;

namespace decorator.Condiment
{
    public class Cinnamon : CondimentDecorator
    {
        public Cinnamon(IBeverage beverage) : base(beverage) {}

        protected override double GetCondimentCost() => 20;

        protected override string GetCondimentDescription() => "Cinnamon";
    }
}