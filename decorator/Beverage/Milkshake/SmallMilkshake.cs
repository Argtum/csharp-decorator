namespace decorator.Beverage.Milkshake
{
    public class SmallMilkshake : Milkshake
    {
        public SmallMilkshake() : base("small Milkshake") {}

        public override double GetCost()
        {
            return 50;
        }
    }
}