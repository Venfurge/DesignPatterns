using State.interfaces;

namespace State.models.PizzaMachineStates
{
    internal class SoldOutState : IPizzaMachineState
    {
        private PizzaMachine _pizzaMachine;

        public SoldOutState(PizzaMachine PizzaMachine)
        {
            _pizzaMachine = PizzaMachine;
        }

        public void InsertMoney()
        {
            Console.WriteLine("You can't insert the money. There is no pizza");
        }

        public void ReturnMoney()
        {
            Console.WriteLine("You can't eject your money before you insert it");
        }

        public void ChoosePizza()
        {
            Console.WriteLine("There is no more pizza");
        }

        public void Dispence()
        {
            Console.WriteLine("There is no more pizza");
        }
    }
}
