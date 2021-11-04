namespace decorator.Beverage.Tea
{
    public class Tea : Beverage
    {
        public Tea(string description = "Tea") : base(description) {}

        public override double GetCost() => 30;
    }
}