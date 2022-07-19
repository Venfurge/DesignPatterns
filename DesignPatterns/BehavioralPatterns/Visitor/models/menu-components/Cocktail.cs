using Visitor.interfaces;

namespace Visitor.models.meals
{
    internal class Cocktail : IMenuComponent
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Condiments { get; set; }
        public double Price { get; set; }

        public Cocktail(string name, string description, string condiments, double price)
            => (Name, Description, Condiments, Price) = (name, description, condiments, price);

        public void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
