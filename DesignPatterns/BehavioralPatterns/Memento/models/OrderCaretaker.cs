using Memento.interfaces;

namespace Memento.models
{
    internal class OrderCaretaker
    {
        private List<AbstractMemento> _mementos = new List<AbstractMemento>();
        private Order _order;

        public OrderCaretaker(Order order)
            => (_order) = (order);

        public void Backup()
        {
            _mementos.Add(_order.Save());
        }

        public void Undo()
        {
            if (_mementos == null || _mementos.Count == 0)
            {
                return;
            }

            var memento = _mementos.Last();
            _mementos.Remove(memento);

            try
            {
                _order.Restore(memento);
            }
            catch (Exception)
            {

            }
        }

        public void ShowHistory()
        {
            foreach (var memento in _mementos)
            {
                Console.WriteLine(memento.GetState());
            }
        }
    }
}
