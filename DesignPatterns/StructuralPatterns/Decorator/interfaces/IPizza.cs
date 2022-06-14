namespace Decorator.interfaces
{
    internal interface IPizza
    {
        public string Description { get; set; }
        public double Price { get; set; }

        public double getPrice();
        public string getDescription();
    }
}
