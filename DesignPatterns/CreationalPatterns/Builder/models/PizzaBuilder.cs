using Builder.interfaces;

namespace Builder.models
{
    internal class PizzaBuilder : IPizzaBuilder
    {
        private Pizza _pizza;

        public PizzaBuilder()
        {
            _pizza = new Pizza();
        }

        public Pizza GetResult()
        {
            Pizza result = _pizza;
            Reset();
            return result;
        }

        public void SetCheesePizza()
        {
            Reset();
            SetName("Cheese pizza");
            SetDescription("A lot of mozzarella");
            AddTomatoSauce();
            AddMozzarella();
        }

        public void SetCezarioPizza()
        {
            Reset();
            SetName("Cezario pizza");
            SetDescription("Classic salad in pizza view");
            AddCezarioSauce();
            AddSalad();
            AddPepperoni();
            AddMozzarella();
        }

        public void SetBrandPizza()
        {
            Reset();
            SetName("Brand pizza");
            SetDescription("Our new brand pizza");
            AddTomatoSauce();
            AddPepperoni();
            AddPineapple();
            AddMozzarella();
        }

        #region Interface implementation

        public void Reset()
        {
            _pizza = new Pizza();
        }

        public void AddCezarioSauce()
        {
            _pizza.IsCezarioSauce = true;
        }

        public void SetDescription(string Description)
        {
            _pizza.Description = Description;
        }

        public void AddMozzarella()
        {
            _pizza.IsMozzarella = true;
        }

        public void SetName(string Name)
        {
            _pizza.Name = Name;
        }

        public void AddPepperoni()
        {
            _pizza.IsPepperoni = true;
        }

        public void AddPineapple()
        {
            _pizza.IsPineapple = true;
        }

        public void AddSalad()
        {
            _pizza.IsSalad = true;
        }

        public void AddTomatoSauce()
        {
            _pizza.IsTomatoSauce = true;
        }

        #endregion
    }
}
