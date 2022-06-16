// See https://aka.ms/new-console-template for more information
using Singleton.models;

BasicSingleton basicSingleton = BasicSingleton.Instance;
Console.WriteLine(basicSingleton.Value);

SingletonWithLock singletonWithLock = SingletonWithLock.Instance;
Console.WriteLine(singletonWithLock.Value);

SingletonWithLockDoubleCheck singletonWithLockDoubleCheck = SingletonWithLockDoubleCheck.Instance;
Console.WriteLine(singletonWithLockDoubleCheck.Value);

NotLazySingleton notLazySingleton = NotLazySingleton.Instance;
Console.WriteLine(notLazySingleton.Value);

LazyTypeSingleton lazyTypeSingleton = LazyTypeSingleton.Instance;
Console.WriteLine(lazyTypeSingleton.Value);
