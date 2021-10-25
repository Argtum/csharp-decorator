using decorator.Beverage;

namespace decorator.Condiment
{
    public class MilkCream : CondimentDecorator
    {
        public MilkCream(IBeverage beverage) : base(beverage) {}

        protected override double GetCondimentCost()
        {
            return 25;
        }

        protected override string GetCondimentDescription()
        {
            return "Milk cream";
        }
    }
}