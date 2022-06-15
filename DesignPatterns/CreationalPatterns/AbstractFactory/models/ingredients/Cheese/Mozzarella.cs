using AbstractFactory.interfaces.ingredients;

namespace AbstractFactory.models.Cheese
{
    internal class Mozzarella : ICheese
    {
        public string Name { get; set; } = "Mozzarella";
    }
}
