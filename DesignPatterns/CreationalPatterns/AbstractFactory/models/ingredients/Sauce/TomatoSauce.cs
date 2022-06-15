using AbstractFactory.interfaces.ingredients;

namespace AbstractFactory.models.Sauce
{
    internal class TomatoSauce : ISauce
    {
        public string Name { get; set; } = "Tomato-based sauce";
    }
}
