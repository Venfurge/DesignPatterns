namespace Adapter.interfaces
{
    internal interface IPizza
    {
        public string Name { get; set; }

        public void Bake();
        public void Cut();
        public void Box();
    }
}
