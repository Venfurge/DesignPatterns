using Strategy.interfaces;
using Strategy.models.BakeStrategies;

namespace Strategy.models
{
    internal abstract class Pizza
    {
        private IBakeStrategy _bakeStrategy = new RawBakeStrategy();

        public string Name { get; set; }
        public double Price { get; set; }

        public Pizza(string name, double price) =>
            (Name, Price) = (name, price);

        public void setBakeStrategy(IBakeStrategy bakeStrategy) 
        {
            this._bakeStrategy = bakeStrategy;
        }

        public void Bake() 
        {
            this._bakeStrategy.Bake();
        }

        public abstract void Display();
    }
}
