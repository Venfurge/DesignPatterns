using AbstractFactory.interfaces.ingredients;

namespace AbstractFactory.models.Cheese
{
    internal class Granapadano : ICheese
    {
        public string Name { get; set; } = "Grana Padano";
    }
}
