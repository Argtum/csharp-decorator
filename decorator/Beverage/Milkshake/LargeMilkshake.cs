namespace decorator.Beverage.Milkshake
{
    public class LargeMilkshake : Milkshake
    {
        public LargeMilkshake() : base("large Milkshake") {}

        public override double GetCost() => 80;
    }
}