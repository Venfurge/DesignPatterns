namespace Strategy.models.PizzaModels
{
    internal class NYPizza : Pizza
    {
        public NYPizza(string name, double price)
            : base(name, price) { }


        public override void Display()
        {
            Console.WriteLine($"New York Pizza | {Name} | Price: {Price}$");
        }
    }
}
