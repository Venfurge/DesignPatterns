using State.interfaces;
using State.models.PizzaMachineStates;

namespace State.models
{
    internal class PizzaMachine
    {
        public SoldOutState SoldOutState;
        public NoMoneyState NoMoneyState;
        public HasMoneyState HasMoneyState;
        public DispencedState DispencedState;

        private IPizzaMachineState _state;
        private int _count = 0;

        public PizzaMachine(int Count)
        {
            SoldOutState = new SoldOutState(this);
            NoMoneyState = new NoMoneyState(this);
            HasMoneyState = new HasMoneyState(this);
            DispencedState = new DispencedState(this);

            _state = SoldOutState;
            _count = Count;

            if (_count > 0)
            {
                _state = NoMoneyState;
            }
        }

        public void SetState(IPizzaMachineState state)
        {
            _state = state;
        }

        public void InsertMoney()
        {
            _state.InsertMoney();
        }

        public void ReturnMoney()
        {
            _state.ReturnMoney();
        }

        public void ChoosePizza()
        {
            _state.ChoosePizza();
            _count--;
            _state.Dispence();
        }

        public int GetCount()
        {
            return _count;
        }
    }
}
