using State.interfaces;

namespace State.models.PizzaMachineStates
{
    internal class DispencedState : IPizzaMachineState
    {
        private PizzaMachine _pizzaMachine;

        public DispencedState(PizzaMachine PizzaMachine)
        {
            _pizzaMachine = PizzaMachine;
        }


        public void InsertMoney()
        {
            Console.WriteLine("You can't insert the money. Your pizza is baking...");
        }

        public void ReturnMoney()
        {
            Console.WriteLine("You can't eject your money. Your pizza is already baking...");
        }

        public void ChoosePizza()
        {
            Console.WriteLine("Your pizza is baking... Please wait");
        }

        public void Dispence()
        {
            Console.WriteLine("There is your pizza");
            if (_pizzaMachine.GetCount() == 0)
            {
                _pizzaMachine.SetState(_pizzaMachine.SoldOutState);
                return;
            }

            _pizzaMachine.SetState(_pizzaMachine.NoMoneyState);
        }
    }
}
