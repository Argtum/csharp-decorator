using decorator.Beverage;

namespace decorator.Condiment
{
    public abstract class CondimentDecorator : IBeverage
    {
        private readonly IBeverage _beverage;

        protected CondimentDecorator(IBeverage beverage)
        {
            _beverage = beverage;
        }

        protected abstract string GetCondimentDescription();
        protected abstract double GetCondimentCost();

        public string GetDescription()
        {
            return _beverage.GetDescription() + ", " + GetCondimentDescription();
        }

        public double GetCost()
        {
            return _beverage.GetCost() + GetCondimentCost();
        }
    }
}