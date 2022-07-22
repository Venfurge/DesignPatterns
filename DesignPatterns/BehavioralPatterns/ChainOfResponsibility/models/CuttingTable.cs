using ChainOfResponsibility.enums;

namespace ChainOfResponsibility.models
{
    internal class CuttingTable
    {
        private CuttingPattern? _pattern;

        public void Cut(Pizza pizza)
        {
            if (_pattern == null)
            {
                throw new Exception("Choose cutting pattern");
            }

            pizza.IsCutted = true;
        }

        public void SetCuttingPattern(CuttingPattern pattern)
        {
            _pattern = pattern;
        }
    }
}
