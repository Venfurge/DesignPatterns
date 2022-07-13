using Bridge.interfaces;

namespace Bridge.models.Additions
{
    internal class TomatoSauce : IAdditions
    {
        public double Price { get; set; } = 0.99;
        public int Spiciness { get; set; }
    }
}
