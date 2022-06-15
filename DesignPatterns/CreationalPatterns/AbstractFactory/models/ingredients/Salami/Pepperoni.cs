using AbstractFactory.interfaces.ingredients;

namespace AbstractFactory.models.Salami
{
    internal class Pepperoni : ISalami
    {
        public string Name { get; set; } = "Pepperoni";
    }
}
