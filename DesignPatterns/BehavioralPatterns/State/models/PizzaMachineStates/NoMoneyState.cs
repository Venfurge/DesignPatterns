using State.interfaces;

namespace State.models.PizzaMachineStates
{
    internal class NoMoneyState : IPizzaMachineState
    {
        private PizzaMachine _pizzaMachine;

        public NoMoneyState(PizzaMachine PizzaMachine)
        {
            _pizzaMachine = PizzaMachine;
        }

        public void InsertMoney()
        {
            _pizzaMachine.SetState(_pizzaMachine.HasMoneyState);
            Console.WriteLine("You inserted money. Now choose pizza");
        }

        public void ReturnMoney()
        {
            Console.WriteLine("You haven't inserted money");
        }

        public void ChoosePizza()
        {
            Console.WriteLine("You haven't inserted money");
        }

        public void Dispence()
        {
            Console.WriteLine("You need to pay first");
        }
    }
}
