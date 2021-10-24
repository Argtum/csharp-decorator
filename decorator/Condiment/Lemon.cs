using decorator.Beverage;

namespace decorator.Condiment
{
    public class Lemon : CondimentDecorator
    {
        private readonly uint _quantity;
        
        public Lemon(IBeverage beverage, uint quantity = 1) : base(beverage)
        {
            _quantity = quantity;
        }

        protected override double GetCondimentCost()
        {
            return 10.0 * _quantity;
        }

        protected override string GetCondimentDescription()
        {
            return "Lemon x " + _quantity;
        }
    }
}