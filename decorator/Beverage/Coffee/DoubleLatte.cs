namespace decorator.Beverage.Coffee
{
    public class DoubleLatte : Coffee
    {
        public DoubleLatte() : base("Double latte") {}

        public override double GetCost() => 130;
    }
}