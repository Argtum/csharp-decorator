namespace decorator.Beverage.Coffee
{
    public class Cappuccino : Coffee
    {
        public Cappuccino() : base("Cappuccino") {}
        
        public override double GetCost()
        {
            return 80;
        }
    }
}