using Command.interfaces;
using Command.models.commands;

namespace Command.models
{
    internal class Cook
    {
        public double BakingTemp { get; set; }
        public string BakeMode { get; set; }

        private ICommand _onBake = new NoCommand();
        private ICommand _onCut = new NoCommand();
        private ICommand _onBox = new NoCommand();

        public Cook(double bakingTemp, string bakeMode) 
            => (BakingTemp, BakeMode) = (bakingTemp, bakeMode);

        public void Bake()
        {
            _onBake.Execute();
        }

        public void Cut()
        {
            _onCut.Execute();
        }

        public void Box()
        {
            _onBox.Execute();
        }

        public void UnBox()
        {
            _onBox.Undo();
        }

        public void setBakeCommand(ICommand OnBake)
        {
            _onBake = OnBake;
        }

        public void setCutCommand(ICommand OnCut)
        {
            _onCut = OnCut;
        }

        public void setBoxCommand(ICommand OnBox)
        {
            _onBox = OnBox;
        }
    }
}
