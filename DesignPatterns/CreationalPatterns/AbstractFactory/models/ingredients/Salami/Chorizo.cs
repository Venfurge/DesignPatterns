using AbstractFactory.interfaces.ingredients;

namespace AbstractFactory.models.Salami
{
    internal class Chorizo : ISalami
    {
        public string Name { get; set; } = "Chorizo";
    }
}
