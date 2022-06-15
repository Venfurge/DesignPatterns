using FactoryMethod.interfaces;

namespace FactoryMethod.models.ChicagoPizza
{
    internal class ChicagoCezarioPizza : Pizza
    {
        public override string Sause { get; set; } = "Cezario heavy sause";
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
