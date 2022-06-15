namespace FactoryMethod.interfaces
{
    internal abstract class Pizza
    {
        public abstract string Sause { get; set; }
        public abstract string Dought { get; set; }


        public abstract void Bake();
        public abstract void Cut();
        public abstract void Box();
        public void DisplayDeatails()
        {
            Console.WriteLine($"Sause: {Sause}, Dought: {Dought}");
        }
    }
}
