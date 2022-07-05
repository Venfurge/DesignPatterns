namespace State.interfaces
{
    internal interface IPizzaMachineState
    {
        public void InsertMoney();
        public void ReturnMoney();
        public void ChoosePizza();
        public void Dispence();
    }
}
