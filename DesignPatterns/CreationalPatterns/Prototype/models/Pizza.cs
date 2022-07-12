namespace Prototype.models
{
    internal class Pizza
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public Pizza(string name, string description, double price)
            => (Name, Description, Price) = (name, description, price);

        public Pizza ShallowCopy()
        {
            return (Pizza)MemberwiseClone();
        }

        public Pizza DeepCopy()
        {
            Pizza clone = (Pizza)MemberwiseClone();
            clone.Name = Name;
            return clone;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {Name}, Description: {Description}, Price: {Price}");
        }
    }
}
