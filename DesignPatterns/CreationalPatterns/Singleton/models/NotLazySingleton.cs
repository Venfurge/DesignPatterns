namespace Singleton.models
{
    //Not quite lazy singleton.
    //Not Lazy
    //Thread-safe without using locks
    internal sealed class NotLazySingleton
    {
        private static readonly NotLazySingleton instance = new NotLazySingleton();
        private NotLazySingleton() { }

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static NotLazySingleton() { }

        public static NotLazySingleton Instance
        {
            get
            {
                return instance;
            }
        }

        //Value to test singleton
        public string Value { get; set; } = "Not lazy singleton";
    }
}
