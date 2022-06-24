using Iterator.interfaces;
using System.Collections;

namespace Iterator.models.iterators
{
    internal class PizzaCollection : interfaces.IteratorAggregate
    {
        List<IPizza> _pizzaCollection = new List<IPizza>();

        bool _direction = false;

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public List<IPizza> GetItems()
        {
            return _pizzaCollection;
        }

        public void AddItem(IPizza pizza)
        {
            _pizzaCollection.Add(pizza);
        }

        public override IEnumerator GetEnumerator()
        {
            return new OrderIterator(this, _direction);
        }
    }
}
