
# Facade

**Facade** is a structural design pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.

## Solution

![](https://github.com/Venfurge/DesignPatterns/blob/Facade/images/Facade_diagram_2.png?raw=true)

A facade is a class that provides a simple interface to a complex subsystem which contains lots of moving parts. A facade might provide limited functionality in comparison to working with the subsystem directly. However, it includes only those features that clients really care about.

Having a facade is handy when you need to integrate your app with a sophisticated library that has dozens of features, but you just need a tiny bit of its functionality.

For instance, an app that uploads short funny videos with cats to social media could potentially use a professional video conversion library. However, all that it really needs is a class with the single method encode(filename, format). After creating such a class and connecting it with the video conversion library, you’ll have your first facade.

## Structure

![](https://github.com/Venfurge/DesignPatterns/blob/Facade/images/Facade_diagram.png?raw=true)

## Pros and Cons

### Pros
 - You can isolate your code from the complexity of a subsystem.
 ### Cons
 - A facade can become a **god object** coupled to all classes of an app.

 ##
 Content from https://refactoring.guru/design-patterns/facade

 For more information follow the link above.
