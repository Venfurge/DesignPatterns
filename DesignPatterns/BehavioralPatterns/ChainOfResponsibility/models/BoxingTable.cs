namespace ChainOfResponsibility.models
{
    internal class BoxingTable
    {
        private int _boxCount = 10;
        public void Box(Pizza pizza)
        {
            if (_boxCount <= 0)
            {
                throw new Exception("Out of boxes");
            }

            pizza.IsBoxed = true;
            _boxCount--;
        }

        public void AddBoxes(int boxCount)
        {
            if (boxCount > 0)
            {
                _boxCount += boxCount;
            }
        }
    }
}
