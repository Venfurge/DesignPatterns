using Memento.interfaces;

namespace Memento.models
{
    internal class Order
    {
        private List<Pizza> _order;

        public Order(List<Pizza> order)
            => (_order) = (order);

        public void ProduceAnOrder()
        {
            Console.WriteLine("Order produced");
            _order?.ForEach(pizza => pizza.Print());
        }

        public void ChangeOrder(List<Pizza> order)
        {
            _order = order;
        }

        public AbstractMemento Save()
        {
            return new OrderMemento(_order);
        }

        public void Restore(AbstractMemento memento)
        {
            if (!(memento is OrderMemento))
            {
                throw new Exception("Unknown memento type");
            }

            _order = (memento as OrderMemento).GetState();
        }
    }
}
