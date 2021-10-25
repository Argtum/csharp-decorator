using decorator.Beverage;

namespace decorator.Condiment
{
    public class Сhocolate : CondimentDecorator
    {
        private const uint MaxQuantity = 5;
        private readonly uint _quantity;
        
        public Сhocolate(IBeverage beverage, uint quantity = 1) : base(beverage)
        {
            _quantity = MaxQuantity < quantity ? MaxQuantity : quantity;
        }

        protected override double GetCondimentCost()
        {
            return 10.0 * _quantity;
        }

        protected override string GetCondimentDescription()
        {
            return "Сhocolate x " + _quantity;
        }
    }
}