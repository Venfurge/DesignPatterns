namespace Singleton.models
{
    //.Net 4 Lazy Singleton.
    //Lazy
    //Thread-safe
    //Easy to implement
    internal sealed class LazyTypeSingleton
    {
        private static readonly Lazy<LazyTypeSingleton> lazy =
            new Lazy<LazyTypeSingleton>(() => new LazyTypeSingleton());

        private LazyTypeSingleton() { }

        public static LazyTypeSingleton Instance { get { return lazy.Value; } }

        //Value to test singleton
        public string Value { get; set; } = "Lazy typed singleton";
    }
}
