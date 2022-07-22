
# Chain of Responsibility

**Chain of Responsibility** is a behavioral design pattern that lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.

## Solution

Like many other behavioral design patterns, the Chain of Responsibility relies on transforming particular behaviors into stand-alone objects called handlers. In our case, each check should be extracted to its own class with a single method that performs the check. The request, along with its data, is passed to this method as an argument.

The pattern suggests that you link these handlers into a chain. Each linked handler has a field for storing a reference to the next handler in the chain. In addition to processing a request, handlers pass the request further along the chain. The request travels along the chain until all handlers have had a chance to process it.

Here’s the best part: a handler can decide not to pass the request further down the chain and effectively stop any further processing.

In our example with ordering systems, a handler performs the processing and then decides whether to pass the request further down the chain. Assuming the request contains the right data, all the handlers can execute their primary behavior, whether it’s authentication checks or caching.

![](https://github.com/Venfurge/DesignPatterns/blob/ChainOfResponsibility/images/CoR_diagram_2.png?raw=true)

However, there’s a slightly different approach (and it’s a bit more canonical) in which, upon receiving a request, a handler decides whether it can process it. If it can, it doesn’t pass the request any further. So it’s either only one handler that processes the request or none at all. This approach is very common when dealing with events in stacks of elements within a graphical user interface.

For instance, when a user clicks a button, the event propagates through the chain of GUI elements that starts with the button, goes along its containers (like forms or panels), and ends up with the main application window. The event is processed by the first element in the chain that’s capable of handling it. This example is also noteworthy because it shows that a chain can always be extracted from an object tree.

![](https://github.com/Venfurge/DesignPatterns/blob/ChainOfResponsibility/images/CoR_diagram_.png?raw=true)

It’s crucial that all handler classes implement the same interface. Each concrete handler should only care about the following one having the execute method. This way you can compose chains at runtime, using various handlers without coupling your code to their concrete classes.

## Structure

![](https://github.com/Venfurge/DesignPatterns/blob/ChainOfResponsibility/images/CoR_diagram.png?raw=true)

## Pros and Cons

### Pros
 - You can control the order of request handling.
 - Single Responsibility Principle. You can decouple classes that invoke operations from classes that perform operations.
 - Open/Closed Principle. You can introduce new handlers into the app without breaking the existing client code.
### Cons
 - Some requests may end up unhandled.

 ##
 Content from https://refactoring.guru/design-patterns/chain-of-responsibility

 For more information follow the link above.
