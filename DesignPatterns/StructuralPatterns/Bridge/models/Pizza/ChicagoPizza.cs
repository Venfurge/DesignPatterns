using Bridge.interfaces;

namespace Bridge.models.Pizza
{
    internal class ChicagoPizza : IPizza
    {
        public List<IAdditions> Additions { get; set; }
        public ChicagoPizza(List<IAdditions> additions)
            => (Additions) = (additions);
    }
}
