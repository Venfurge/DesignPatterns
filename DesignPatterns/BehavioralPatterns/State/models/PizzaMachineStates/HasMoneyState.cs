using State.interfaces;

namespace State.models.PizzaMachineStates
{
    internal class HasMoneyState : IPizzaMachineState
    {
        private PizzaMachine _pizzaMachine;

        public HasMoneyState(PizzaMachine PizzaMachine)
        {
            _pizzaMachine = PizzaMachine;
        }

        public void InsertMoney()
        {
            Console.WriteLine("Money already inserted");
        }

        public void ReturnMoney()
        {
            Console.WriteLine("Money returned");
            _pizzaMachine.SetState(_pizzaMachine.NoMoneyState);
        }

        public void ChoosePizza()
        {
            Console.WriteLine("Take your pizza...");
            _pizzaMachine.SetState(_pizzaMachine.DispencedState);
        }

        public void Dispence()
        {
            Console.WriteLine("Please choose pizza first");
        }
    }
}
