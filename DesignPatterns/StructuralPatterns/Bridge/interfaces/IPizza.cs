namespace Bridge.interfaces
{
    internal interface IPizza
    {
        public List<IAdditions> Additions { get; set; }
        public double Price()
        {
            return Additions.Sum(addition => addition.Price);
        }
    }
}
