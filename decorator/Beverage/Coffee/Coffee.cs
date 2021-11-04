namespace decorator.Beverage.Coffee
{
    public class Coffee : Beverage
    {
        public Coffee(string description = "Coffee") : base(description) {}

        public override double GetCost() => 60;
    }
}