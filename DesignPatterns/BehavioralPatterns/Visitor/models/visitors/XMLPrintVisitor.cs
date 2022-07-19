using Visitor.interfaces;
using Visitor.models.meals;

namespace Visitor.models.visitors
{
    internal class XMLPrintVisitor : IVisitor
    {
        public void Visit(Cocktail menuComponent)
        {
            string XMLString = 
                $"<Cocktail "
                + $"Name=\"{menuComponent.Name}\" "
                + $"Price=\"{menuComponent.Price}\" "
                + $"Description=\"{menuComponent.Description}\" "
                + $"Condiments=\"{menuComponent.Condiments}\""
                + $"></Cocktail>";

            Console.WriteLine(XMLString);
        }

        public void Visit(Hookah menuComponent)
        {
            string XMLString =
                $"<Hookah "
                + $"Flavour=\"{menuComponent.Flavour}\" "
                + $"Price=\"{menuComponent.Price}\" "
                + $"Strong=\"{menuComponent.StrongLevel}\""
                + $"></Hookah>";

            Console.WriteLine(XMLString);
        }

        public void Visit(Pizza menuComponent)
        {
            string XMLString =
                $"<Pizza "
                + $"Name=\"{menuComponent.Name}\" "
                + $"Price=\"{menuComponent.Price}\" "
                + $"Description=\"{menuComponent.Description}\""
                + $"></Pizza>";

            Console.WriteLine(XMLString);
        }
    }
}
