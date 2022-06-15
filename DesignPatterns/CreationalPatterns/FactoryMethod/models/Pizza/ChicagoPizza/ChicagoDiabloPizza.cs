using FactoryMethod.interfaces;

namespace FactoryMethod.models.ChicagoPizza
{
    internal class ChicagoDiabloPizza : Pizza
    {
        public override string Sause { get; set; } = "Extremely hot sause";
        public override string Dought { get; set; } = "Rough dought";

        public override void Bake()
        {
            Console.WriteLine("Pizza is baking");
        }

        public override void Box()
        {
            Console.WriteLine("Pizza is boxing into Circle-Chicago brand box");
        }

        public override void Cut()
        {
            Console.WriteLine("Pizza is cutting by square pattern");
        }
    }
}
