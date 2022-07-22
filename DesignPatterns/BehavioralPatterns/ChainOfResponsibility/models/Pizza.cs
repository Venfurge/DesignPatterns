namespace ChainOfResponsibility.models
{
    internal class Pizza
    {
        public string Name { get; set; }
        public bool IsBaked { get; set; } = false;
        public bool IsCutted { get; set; } = false;
        public bool IsBoxed { get; set; } = false;

        public Pizza(string name)
            => (Name) = (name);
    }
}
