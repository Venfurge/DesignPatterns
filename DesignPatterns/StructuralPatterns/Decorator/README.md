
# Decorator

**Decorator** is a structural design pattern that lets you attach new behaviors to objects by placing these objects inside special wrapper objects that contain the behaviors.

## Solution

Extending a class is the first thing that comes to mind when you need to alter an object’s behavior. However, inheritance has several serious caveats that you need to be aware of.

- Inheritance is static. You can’t alter the behavior of an existing object at runtime. You can only replace the whole object with another one that’s created from a different subclass.
- Subclasses can have just one parent class. In most languages, inheritance doesn’t let a class inherit behaviors of multiple classes at the same time.
One of the ways to overcome these caveats is by using Aggregation or Composition  instead of Inheritance. Both of the alternatives work almost the same way: one object has a reference to another and delegates it some work, whereas with inheritance, the object itself is able to do that work, inheriting the behavior from its superclass.

With this new approach you can easily substitute the linked “helper” object with another, changing the behavior of the container at runtime. An object can use the behavior of various classes, having references to multiple objects and delegating them all kinds of work. Aggregation/composition is the key principle behind many design patterns, including Decorator. On that note, let’s return to the pattern discussion.

![](https://github.com/Venfurge/DesignPatterns/blob/Decorator/images/Decorator_diagram_2.png?raw=true)

“Wrapper” is the alternative nickname for the Decorator pattern that clearly expresses the main idea of the pattern. A wrapper is an object that can be linked with some target object. The wrapper contains the same set of methods as the target and delegates to it all requests it receives. However, the wrapper may alter the result by doing something either before or after it passes the request to the target.

When does a simple wrapper become the real decorator? As I mentioned, the wrapper implements the same interface as the wrapped object. That’s why from the client’s perspective these objects are identical. Make the wrapper’s reference field accept any object that follows that interface. This will let you cover an object in multiple wrappers, adding the combined behavior of all the wrappers to it.

In our notifications example, let’s leave the simple email notification behavior inside the base Notifier class, but turn all other notification methods into decorators.

![](https://github.com/Venfurge/DesignPatterns/blob/Decorator/images/Decorator_diagram_3.png?raw=true)

The client code would need to wrap a basic notifier object into a set of decorators that match the client’s preferences. The resulting objects will be structured as a stack.

![](https://github.com/Venfurge/DesignPatterns/blob/Decorator/images/Decorator_diagram_4.png?raw=true)

The last decorator in the stack would be the object that the client actually works with. Since all decorators implement the same interface as the base notifier, the rest of the client code won’t care whether it works with the “pure” notifier object or the decorated one.

We could apply the same approach to other behaviors such as formatting messages or composing the recipient list. The client can decorate the object with any custom decorators, as long as they follow the same interface as the others.

## Structure

![](https://github.com/Venfurge/DesignPatterns/blob/Decorator/images/Decorator_diagram.png?raw=true)

## Pros and Cons

### Pros
 - You can extend an object’s behavior without making a new subclass.
 - You can add or remove responsibilities from an object at runtime.
 - You can combine several behaviors by wrapping an object into multiple decorators.
 - Single Responsibility Principle. You can divide a monolithic class that implements many possible variants of behavior into several smaller classes.
 ### Cons
 - It’s hard to remove a specific wrapper from the wrappers stack.
 - It’s hard to implement a decorator in such a way that its behavior doesn’t depend on the order in the decorators stack.
 - The initial configuration code of layers might look pretty ugly.

 ##
 Content from https://refactoring.guru/design-patterns/decorator

 For more information follow the link above.
