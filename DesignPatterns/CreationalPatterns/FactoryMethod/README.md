
# Factory Method

**Factory Method** is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.



## Solution

The Factory Method pattern suggests that you replace direct object construction calls (using the new operator) with calls to a special factory method. Don’t worry: the objects are still created via the new operator, but it’s being called from within the factory method. Objects returned by a factory method are often referred to as products.

![](https://github.com/Venfurge/DesignPatterns/blob/FactoryMethod/images/Factory_Method_diagram_2.png?raw=true)

At first glance, this change may look pointless: we just moved the constructor call from one part of the program to another. However, consider this: now you can override the factory method in a subclass and change the class of products being created by the method.

![](https://github.com/Venfurge/DesignPatterns/blob/FactoryMethod/images/Factory_Method_diagram_3.png?raw=true)

For example, both Truck and Ship classes should implement the Transport interface, which declares a method called deliver. Each class implements this method differently: trucks deliver cargo by land, ships deliver cargo by sea. The factory method in the RoadLogistics class returns truck objects, whereas the factory method in the SeaLogistics class returns ships.

![](https://github.com/Venfurge/DesignPatterns/blob/FactoryMethod/images/Factory_Method_diagram_4.png?raw=true)

The code that uses the factory method (often called the client code) doesn’t see a difference between the actual products returned by various subclasses. The client treats all the products as abstract Transport. The client knows that all transport objects are supposed to have the deliver method, but exactly how it works isn’t important to the client.

## Structure

![](https://github.com/Venfurge/DesignPatterns/blob/FactoryMethod/images/Factory_Method_diagram.png?raw=true)

## Pros and Cons

### Pros
 - You avoid tight coupling between the creator and the concrete products.
 - Single Responsibility Principle. You can move the product creation code into one place in the program, making the code easier to support.
 - Open/Closed Principle. You can introduce new types of products into the program without breaking existing client code.
 ### Cons
 - The code may become more complicated since you need to introduce a lot of new subclasses to implement the pattern. The best case scenario is when you’re introducing the pattern into an existing hierarchy of creator classes.

 ##
 Content from https://refactoring.guru/design-patterns/factory-method

 For more information follow the link above.
