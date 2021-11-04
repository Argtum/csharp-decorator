using decorator.Beverage;

namespace decorator.Condiment
{
    public enum SyrupType
    {
        Chocolate,
        Maple
    }
    
    public class Syrup : CondimentDecorator
    {
        private readonly SyrupType _type;
        
        public Syrup(IBeverage beverage, SyrupType type) : base(beverage)
        {
            _type = type;
        }

        protected override string GetCondimentDescription() => _type == SyrupType.Chocolate ? "Chocolate" : "Maple" + " syrup";

        protected override double GetCondimentCost() => 15;
    }
}