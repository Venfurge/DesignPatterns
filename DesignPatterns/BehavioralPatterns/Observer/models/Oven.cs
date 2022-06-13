using Observer.interfaces;

namespace Observer.models
{
    internal class Oven : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();
        private Pizza pizza;

        public Oven(Pizza Pizza)
            => (pizza) = (Pizza);

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            _observers.ForEach(observer => observer.Update(pizza));
        }

        public void BakePizza(Pizza pizza)
        {
            this.pizza = pizza;
            pizza.BakePizza();
            NotifyObservers();
        }
    }
}
