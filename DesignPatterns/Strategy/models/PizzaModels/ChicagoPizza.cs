namespace Strategy.models.PizzaModels
{
    internal class ChicagoPizza : Pizza
    {
        public ChicagoPizza(string name, double price)
            : base(name, price) { }


        public override void Display()
        {
            Console.WriteLine($"Chicago Pizza | {Name} | Price: {Price}$");
        }
    }
}
