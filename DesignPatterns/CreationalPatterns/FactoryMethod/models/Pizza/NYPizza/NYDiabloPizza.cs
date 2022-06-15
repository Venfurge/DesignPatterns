using FactoryMethod.interfaces;

namespace FactoryMethod.models.NYPizza
{
    internal class NYDiabloPizza : Pizza
    {
        public override string Sause { get; set; } = "Lightly-hot chilly sause";
        public override string Dought { get; set; } = "Thin dought";

        public override void Bake()
        {
            Console.WriteLine("Pizza is baking");
        }

        public override void Box()
        {
            Console.WriteLine("Pizza is boxing into Square-NY brand box");
        }

        public override void Cut()
        {
            Console.WriteLine("Pizza is cutting by diagonal pattern");
        }
    }
}
