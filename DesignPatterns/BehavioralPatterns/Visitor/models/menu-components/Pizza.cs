using Visitor.interfaces;

namespace Visitor.models.meals
{
    internal class Pizza : IMenuComponent
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Pizza(string name, string description, double price)
            => (Name, Description, Price) = (name, description, price);

        public void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
