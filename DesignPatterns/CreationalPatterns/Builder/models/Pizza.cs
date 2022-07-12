namespace Builder.models
{
    internal class Pizza
    {
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public bool IsMozzarella { get; set; } = false;
        public bool IsPepperoni { get; set; } = false;
        public bool IsPineapple { get; set; } = false;
        public bool IsTomatoSauce { get; set; } = false;
        public bool IsCezarioSauce { get; set; } = false;
        public bool IsSalad { get; set; } = false;

        public Pizza() { }

        public void Print()
        {
            Console.WriteLine($"Pizza name: {Name} | {Description}");
            Console.WriteLine($"Ingredients:");
            Console.WriteLine($"Mozzarella: {IsMozzarella}");
            Console.WriteLine($"Pepperoni: {IsPepperoni}");
            Console.WriteLine($"Pineapple: {IsPineapple}");
            Console.WriteLine($"TomatoSauce: {IsTomatoSauce}");
            Console.WriteLine($"CezarioSauce: {IsCezarioSauce}");
            Console.WriteLine($"Salad: {IsSalad}");
        }
    }
}
