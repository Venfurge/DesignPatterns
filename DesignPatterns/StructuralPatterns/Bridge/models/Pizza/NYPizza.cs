using Bridge.interfaces;

namespace Bridge.models.Pizza
{
    internal class NYPizza : IPizza
    {
        public List<IAdditions> Additions { get; set; }
        public NYPizza(List<IAdditions> additions)
            => (Additions) = (additions);
    }
}
