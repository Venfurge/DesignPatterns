namespace Flyweight.interfaces
{
    internal interface IPizza
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
