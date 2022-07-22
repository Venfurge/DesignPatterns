namespace ChainOfResponsibility.models
{
    internal class Oven
    {
        private int _temperature = 0;

        public void Bake(Pizza pizza)
        {
            if (_temperature < 200)
            {
                throw new Exception("Temperature is too low to bake");
            }

            if (_temperature > 400)
            {
                throw new Exception("Temperature is too high to bake");
            }

            pizza.IsBaked = true;
        }

        public void SetTemperature(int temperature)
        {
            _temperature = temperature;
        }
    }
}
