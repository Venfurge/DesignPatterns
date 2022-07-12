
# Prototype

**Prototype** is a creational design pattern that lets you copy existing objects without making your code dependent on their classes.

## Solution

The Prototype pattern delegates the cloning process to the actual objects that are being cloned. The pattern declares a common interface for all objects that support cloning. This interface lets you clone an object without coupling your code to the class of that object. Usually, such an interface contains just a single clone method.

The implementation of the clone method is very similar in all classes. The method creates an object of the current class and carries over all of the field values of the old object into the new one. You can even copy private fields because most programming languages let objects access private fields of other objects that belong to the same class.

An object that supports cloning is called a prototype. When your objects have dozens of fields and hundreds of possible configurations, cloning them might serve as an alternative to subclassing.

![](https://github.com/Venfurge/DesignPatterns/blob/Prototype/images/Prototype_diagram_2.png?raw=true)

Here’s how it works: you create a set of objects, configured in various ways. When you need an object like the one you’ve configured, you just clone a prototype instead of constructing a new object from scratch.

## Structure

![](https://github.com/Venfurge/DesignPatterns/blob/Prototype/images/Prototype_diagram.png?raw=true)

## Pros and Cons

### Pros
 - You can clone objects without coupling to their concrete classes.
 - You can get rid of repeated initialization code in favor of cloning pre-built prototypes.
 - You can produce complex objects more conveniently.
 - You get an alternative to inheritance when dealing with configuration presets for complex objects.
### Cons
 - Cloning complex objects that have circular references might be very tricky.

 ##
 Content from https://refactoring.guru/design-patterns/prototype

 For more information follow the link above.
