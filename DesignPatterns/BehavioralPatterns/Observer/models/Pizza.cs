namespace Observer.models
{
    internal class Pizza
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Pizza(string name, double price)
            => (Name, Price) = (name, price);

        public void BakePizza()
        {
            Console.WriteLine($"{Name} pizza was baked");
        }
    }
}
