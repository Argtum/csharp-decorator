namespace decorator.Beverage.Coffee
{
    public class DoubleCappuccino : Coffee
    {        
        public DoubleCappuccino() : base("Double cappuccino") {}

        public override double GetCost()
        {
            return 120;
        }
    }
}