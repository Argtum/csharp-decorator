namespace decorator.Beverage
{
    public abstract class Beverage : IBeverage
    {
        private readonly string _description;

        protected Beverage(string description)
        {
            _description = description;
        }

        public string GetDescription() => _description;

        public abstract double GetCost();
    }
}