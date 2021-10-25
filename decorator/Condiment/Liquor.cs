using decorator.Beverage;

namespace decorator.Condiment
{
    public enum LiquorType
    {
        Nut,
        Chocolate
    }

    public class Liquor : CondimentDecorator
    {
        private readonly LiquorType _type;
    
        public Liquor(IBeverage beverage, LiquorType type = LiquorType.Nut) : base(beverage)
        {
            _type = type;
        }

        protected override string GetCondimentDescription()
        {
            return _type == LiquorType.Nut ? "Nut" : "Chocolate" + " liquor";
        }
    
        protected override double GetCondimentCost()
        {
            return 50;
        }
    }
}