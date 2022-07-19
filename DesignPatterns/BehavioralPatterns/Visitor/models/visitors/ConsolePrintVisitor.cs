using Visitor.interfaces;
using Visitor.models.meals;

namespace Visitor.models.visitors
{
    internal class ConsolePrintVisitor : IVisitor
    {
        public void Visit(Cocktail menuComponent)
        {
            Console.WriteLine($"Name: {menuComponent.Name} | {menuComponent.Price}$");
            Console.WriteLine($"Description: {menuComponent.Description}");
            Console.WriteLine($"Condiments: {menuComponent.Condiments}");
            SplitConsoleMenuComponents();
        }

        public void Visit(Hookah menuComponent)
        {
            Console.WriteLine($"Flavour: {menuComponent.Flavour} | {menuComponent.Price}$");
            Console.WriteLine($"Strong: {menuComponent.StrongLevel}");
            SplitConsoleMenuComponents();
        }

        public void Visit(Pizza menuComponent)
        {
            Console.WriteLine($"Name: {menuComponent.Name} | {menuComponent.Price}$");
            Console.WriteLine($"Description: {menuComponent.Description}");
            SplitConsoleMenuComponents();
        }

        private void SplitConsoleMenuComponents()
        {
            Console.WriteLine($"--------------------------------------");
            Console.WriteLine();
        }
    }
}
