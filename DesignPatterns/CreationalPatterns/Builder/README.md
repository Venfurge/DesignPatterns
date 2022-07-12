
# Builder

**Builder** is a creational design pattern that lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.

## Solution

The Builder pattern suggests that you extract the object construction code out of its own class and move it to separate objects called builders.

![](https://github.com/Venfurge/DesignPatterns/blob/Builder/images/Builder_diagram_2.png?raw=true)

The pattern organizes object construction into a set of steps (buildWalls, buildDoor, etc.). To create an object, you execute a series of these steps on a builder object. The important part is that you don’t need to call all of the steps. You can call only those steps that are necessary for producing a particular configuration of an object.

Some of the construction steps might require different implementation when you need to build various representations of the product. For example, walls of a cabin may be built of wood, but the castle walls must be built with stone.

In this case, you can create several different builder classes that implement the same set of building steps, but in a different manner. Then you can use these builders in the construction process (i.e., an ordered set of calls to the building steps) to produce different kinds of objects.

![](https://github.com/Venfurge/DesignPatterns/blob/Builder/images/Builder_diagram_3.png?raw=true)

For example, imagine a builder that builds everything from wood and glass, a second one that builds everything with stone and iron and a third one that uses gold and diamonds. By calling the same set of steps, you get a regular house from the first builder, a small castle from the second and a palace from the third. However, this would only work if the client code that calls the building steps is able to interact with builders using a common interface.

****Director****

You can go further and extract a series of calls to the builder steps you use to construct a product into a separate class called director. The director class defines the order in which to execute the building steps, while the builder provides the implementation for those steps.

![](https://github.com/Venfurge/DesignPatterns/blob/Builder/images/Builder_diagram_4.png?raw=true)

Having a director class in your program isn’t strictly necessary. You can always call the building steps in a specific order directly from the client code. However, the director class might be a good place to put various construction routines so you can reuse them across your program.

In addition, the director class completely hides the details of product construction from the client code. The client only needs to associate a builder with a director, launch the construction with the director, and get the result from the builder.

## Structure

![](https://github.com/Venfurge/DesignPatterns/blob/Builder/images/Builder_diagram.png?raw=true)

## Pros and Cons

### Pros
 - You can construct objects step-by-step, defer construction steps or run steps recursively.
 - You can reuse the same construction code when building various representations of products.
 - Single Responsibility Principle. You can isolate complex construction code from the business logic of the product.
### Cons
 - The overall complexity of the code increases since the pattern requires creating multiple new classes.

 ##
 Content from https://refactoring.guru/design-patterns/builder

 For more information follow the link above.
