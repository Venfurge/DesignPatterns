
# State

**State** is a behavioral design pattern that lets an object alter its behavior when its internal state changes. It appears as if the object changed its class.

## Solution

The State pattern suggests that you create new classes for all possible states of an object and extract all state-specific behaviors into these classes.

Instead of implementing all behaviors on its own, the original object, called context, stores a reference to one of the state objects that represents its current state, and delegates all the state-related work to that object.

![](https://github.com/Venfurge/DesignPatterns/blob/State/images/State_diagram_2.png?raw=true)

To transition the context into another state, replace the active state object with another object that represents that new state. This is possible only if all state classes follow the same interface and the context itself works with these objects through that interface.

This structure may look similar to the Strategy pattern, but there’s one key difference. In the State pattern, the particular states may be aware of each other and initiate transitions from one state to another, whereas strategies almost never know about each other.

## Structure

![](https://github.com/Venfurge/DesignPatterns/blob/State/images/State_diagram.png?raw=true)

## Pros and Cons

### Pros
 - Single Responsibility Principle. Organize the code related to particular states into separate classes.
 - Open/Closed Principle. Introduce new states without changing existing state classes or the context.
 - Simplify the code of the context by eliminating bulky state machine conditionals.
### Cons
 - Applying the pattern can be overkill if a state machine has only a few states or rarely changes.

 ##
 Content from https://refactoring.guru/design-patterns/state
 
 For more information follow the link above.
