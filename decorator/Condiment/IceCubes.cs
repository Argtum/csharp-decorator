using decorator.Beverage;

namespace decorator.Condiment
{
    public enum IceCubeType
    {
        Dry,
        Water
    }
    
    public class IceCubes : CondimentDecorator
    {
        private readonly uint _quantity;
        private readonly IceCubeType _type;
        
        public IceCubes(IBeverage beverage, uint quantity = 1, IceCubeType type = IceCubeType.Water) : base(beverage)
        {
            _quantity = quantity;
            _type = type;
        }

        protected override string GetCondimentDescription()
        {
            return _type == IceCubeType.Dry ? "Dry" : "Water" + " ice cubes x " + _quantity;
        }
        
        protected override double GetCondimentCost()
        {
            return _type == IceCubeType.Dry ? 10 : 5 * _quantity;
        }
    }
}