
# Abstract Factory

**Abstract Factory** is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.

## Solution

The first thing the Abstract Factory pattern suggests is to explicitly declare interfaces for each distinct product of the product family (e.g., chair, sofa or coffee table). Then you can make all variants of products follow those interfaces. For example, all chair variants can implement the Chair interface; all coffee table variants can implement the CoffeeTable interface, and so on.

![](https://github.com/Venfurge/DesignPatterns/blob/AbstractFactory/images/Abstract_Factory_diagram_2.png?raw=true)

The next move is to declare the Abstract Factory—an interface with a list of creation methods for all products that are part of the product family (for example, createChair, createSofa and createCoffeeTable). These methods must return abstract product types represented by the interfaces we extracted previously: Chair, Sofa, CoffeeTable and so on.

![](https://github.com/Venfurge/DesignPatterns/blob/AbstractFactory/images/Abstract_Factory_diagram_3.png?raw=true)

Now, how about the product variants? For each variant of a product family, we create a separate factory class based on the AbstractFactory interface. A factory is a class that returns products of a particular kind. For example, the ModernFurnitureFactory can only create ModernChair, ModernSofa and ModernCoffeeTable objects.

The client code has to work with both factories and products via their respective abstract interfaces. This lets you change the type of a factory that you pass to the client code, as well as the product variant that the client code receives, without breaking the actual client code.

![](https://github.com/Venfurge/DesignPatterns/blob/AbstractFactory/images/Abstract_Factory_diagram_4.png?raw=true)

Say the client wants a factory to produce a chair. The client doesn’t have to be aware of the factory’s class, nor does it matter what kind of chair it gets. Whether it’s a Modern model or a Victorian-style chair, the client must treat all chairs in the same manner, using the abstract Chair interface. With this approach, the only thing that the client knows about the chair is that it implements the sitOn method in some way. Also, whichever variant of the chair is returned, it’ll always match the type of sofa or coffee table produced by the same factory object.

There’s one more thing left to clarify: if the client is only exposed to the abstract interfaces, what creates the actual factory objects? Usually, the application creates a concrete factory object at the initialization stage. Just before that, the app must select the factory type depending on the configuration or the environment settings.

## Structure

![](https://github.com/Venfurge/DesignPatterns/blob/AbstractFactory/images/Abstract_Factory_diagram.png?raw=true)

## Pros and Cons

### Pros
 - You can be sure that the products you’re getting from a factory are compatible with each other.
 - You avoid tight coupling between concrete products and client code.
 - Single Responsibility Principle. You can extract the product creation code into one place, making the code easier to support.
 - Open/Closed Principle. You can introduce new variants of products without breaking existing client code.
 ### Cons
 - The code may become more complicated than it should be, since a lot of new interfaces and classes are introduced along with the pattern.

 ##
 Content from https://refactoring.guru/design-patterns/abstract-factory

 For more information follow the link above.
