using Memento.interfaces;

namespace Memento.models
{
    internal class OrderMemento : AbstractMemento
    {
        private List<Pizza> _order;
        private DateTime _date;

        public OrderMemento(List<Pizza> order)
        {
            _order = order;
            _date = DateTime.Now;
        }
        public override List<Pizza> GetState()
        {
            return _order;
        }

        public override DateTime GetDate()
        {
            return _date;
        }
    }
}
