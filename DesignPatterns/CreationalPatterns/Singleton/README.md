
# Singleton

**Singleton** is a creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.

## Solution

![](https://github.com/Venfurge/DesignPatterns/blob/Singleton/images/Singleton_diagram_2.png?raw=true)

All implementations of the Singleton have these two steps in common:

- Make the default constructor private, to prevent other objects from using the new operator with the Singleton class.
- Create a static creation method that acts as a constructor. Under the hood, this method calls the private constructor to create an object and saves it in a static field. All following calls to this method return the cached object.

If your code has access to the Singleton class, then it’s able to call the Singleton’s static method. So whenever that method is called, the same object is always returned.

## Structure

![](https://github.com/Venfurge/DesignPatterns/blob/Singleton/images/Singleton_diagram.png?raw=true)

## Pros and Cons

### Pros
 - You can be sure that a class has only a single instance.
 - You gain a global access point to that instance.
 - The singleton object is initialized only when it’s requested for the first time. (Only in lazy realizations)
 ### Cons
 - Violates the Single Responsibility Principle. The pattern solves two problems at the time.
 - The Singleton pattern can mask bad design, for instance, when the components of the program know too much about each other.
 - The pattern requires special treatment in a multithreaded environment so that multiple threads won’t create a singleton object several times.
 - It may be difficult to unit test the client code of the Singleton because many test frameworks rely on inheritance when producing mock objects. Since the constructor of the singleton class is private and overriding static methods is impossible in most languages, you will need to think of a creative way to mock the singleton. Or just don’t write the tests. Or don’t use the Singleton pattern.

 ##
 Content from https://refactoring.guru/design-patterns/singleton

 For more information follow the link above.
