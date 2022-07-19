using Visitor.interfaces;

namespace Visitor.models.meals
{
    internal class Hookah : IMenuComponent
    {
        public int StrongLevel { get; set; }
        public string Flavour { get; set; }
        public double Price { get; set; }

        public Hookah(int strongLevel, string flavour, double price)
            => (StrongLevel, Flavour, Price) = (strongLevel, flavour, price);

        public void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
