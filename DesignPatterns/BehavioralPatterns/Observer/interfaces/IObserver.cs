using Observer.models;

namespace Observer.interfaces
{
    internal interface IObserver
    {
        public void Update(Pizza pizza);
    }
}
