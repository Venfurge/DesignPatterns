using Adapter.interfaces;

namespace Adapter.models
{
    internal class PizzaPieAdapter : IPizza
    {
        public string Name { get; set; }

        private IPie _pie;

        public PizzaPieAdapter(IPie Pie)
        {
            _pie = Pie;
            Name = _pie.Name;
        }

        public void Bake()
        {
            _pie.Bake();
        }

        public void Box()
        {
            _pie.Box();
        }

        public void Cut()
        {
            // Here is better to throw custom exception
            // Or just do nothing like here did
            return;
        }
    }
}
