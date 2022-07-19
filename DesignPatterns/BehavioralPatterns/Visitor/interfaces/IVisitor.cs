using Visitor.models.meals;

namespace Visitor.interfaces
{
    internal interface IVisitor
    {
        public void Visit(Cocktail menuComponent);
        public void Visit(Hookah menuComponent);
        public void Visit(Pizza menuComponent);
    }
}
