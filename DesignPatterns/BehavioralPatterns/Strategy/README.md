
# Strategy

**Strategy** is a behavioral design pattern that lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable.

## Solution

The Strategy pattern suggests that you take a class that does something specific in a lot of different ways and extract all of these algorithms into separate classes called strategies.

The original class, called context, must have a field for storing a reference to one of the strategies. The context delegates the work to a linked strategy object instead of executing it on its own.

The context isn’t responsible for selecting an appropriate algorithm for the job. Instead, the client passes the desired strategy to the context. In fact, the context doesn’t know much about strategies. It works with all strategies through the same generic interface, which only exposes a single method for triggering the algorithm encapsulated within the selected strategy.

This way the context becomes independent of concrete strategies, so you can add new algorithms or modify existing ones without changing the code of the context or other strategies.

## Structure

![](https://github.com/Venfurge/DesignPatterns/blob/Strategy/images/Strategy_diagram.png?raw=true)

## Pros and Cons

### Pros
 - You can swap algorithms used inside an object at runtime.
 - You can isolate the implementation details of an algorithm from the code that uses it.
 - You can replace inheritance with composition.
 - Open/Closed Principle. You can introduce new strategies without having to change the context.
 ### Cons
 - If you only have a couple of algorithms and they rarely change, there’s no real reason to overcomplicate the program with new classes and interfaces that come along with the pattern.
 - Clients must be aware of the differences between strategies to be able to select a proper one.

 ##
 Content from https://refactoring.guru/design-patterns/strategy 

 For more information follow the link above.
