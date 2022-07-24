namespace Mediator.models
{
    internal class Pizza
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsBaked { get; set; } = false;
        public bool IsCutted { get; set; } = false;
        public bool IsBoxed { get; set; } = false;

        public Pizza(string name, double price)
            => (Name, Price) = (name, price);

        public void Print()
        {
            Console.WriteLine($"{Name} pizza | {Price}$ | IsBaked: {IsBaked} | IsCutted: {IsCutted} | IsBoxed: {IsBoxed}");
        }
    }
}
