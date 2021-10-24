namespace decorator.Beverage.Coffee
{
    public class Latte : Coffee
    {
        public Latte() : base("Latte") {}
        
        public override double GetCost()
        {
            return 90;
        }
    }
}