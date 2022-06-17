namespace Facade.interfaces
{
    internal interface IPizza
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public bool isCutted { get; set; }
        public bool isBoxed { get; set; }
    }
}
