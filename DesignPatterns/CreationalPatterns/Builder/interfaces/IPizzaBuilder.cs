namespace Builder.interfaces
{
    internal interface IPizzaBuilder
    {
        public void Reset();
        public void SetName(string Name);
        public void SetDescription(string Description);
        public void AddMozzarella();
        public void AddPepperoni();
        public void AddPineapple();
        public void AddTomatoSauce();
        public void AddCezarioSauce();
        public void AddSalad();
    }
}
