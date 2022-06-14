namespace Decorator.interfaces
{
    internal abstract class PizzaToppingDecorator : Pizza
    {
        public abstract Pizza Pizza { get; set; }

        public override double GetPrice()
        {
            return Pizza.GetPrice() + Price;
        }

        public override List<string> GetDescriptions()
        {
            List<string> desciptionList = Pizza.GetDescriptions();
            desciptionList.Add(Description);
            return desciptionList;
        }
    }
}
