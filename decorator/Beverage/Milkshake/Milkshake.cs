namespace decorator.Beverage.Milkshake
{
    public class Milkshake : Beverage
    {
        public Milkshake(string description = "Milkshake") : base(description) {}

        public override double GetCost() => 60;
    }
}