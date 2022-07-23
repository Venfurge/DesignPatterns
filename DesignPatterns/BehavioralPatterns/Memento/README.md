
# Memento

**Memento** is a behavioral design pattern that lets you save and restore the previous state of an object without revealing the details of its implementation.

## Solution

All problems that we’ve just experienced are caused by broken encapsulation. Some objects try to do more than they are supposed to. To collect the data required to perform some action, they invade the private space of other objects instead of letting these objects perform the actual action.

The Memento pattern delegates creating the state snapshots to the actual owner of that state, the originator object. Hence, instead of other objects trying to copy the editor’s state from the “outside,” the editor class itself can make the snapshot since it has full access to its own state.

The pattern suggests storing the copy of the object’s state in a special object called memento. The contents of the memento aren’t accessible to any other object except the one that produced it. Other objects must communicate with mementos using a limited interface which may allow fetching the snapshot’s metadata (creation time, the name of the performed operation, etc.), but not the original object’s state contained in the snapshot.

![](https://github.com/Venfurge/DesignPatterns/blob/Memento/images/Memento_diagram_2.png?raw=true)

Such a restrictive policy lets you store mementos inside other objects, usually called caretakers. Since the caretaker works with the memento only via the limited interface, it’s not able to tamper with the state stored inside the memento. At the same time, the originator has access to all fields inside the memento, allowing it to restore its previous state at will.

In our text editor example, we can create a separate history class to act as the caretaker. A stack of mementos stored inside the caretaker will grow each time the editor is about to execute an operation. You could even render this stack within the app’s UI, displaying the history of previously performed operations to a user.

When a user triggers the undo, the history grabs the most recent memento from the stack and passes it back to the editor, requesting a roll-back. Since the editor has full access to the memento, it changes its own state with the values taken from the memento.

## Structure

***Implementation based on nested classes***

The classic implementation of the pattern relies on support for nested classes, available in many popular programming languages (such as C++, C#, and Java).

![](https://github.com/Venfurge/DesignPatterns/blob/Memento/images/Memento_diagram_3.png?raw=true)

***Implementation based on an intermediate interface***

There’s an alternative implementation, suitable for programming languages that don’t support nested classes (yeah, PHP, I’m talking about you).

![](https://github.com/Venfurge/DesignPatterns/blob/Memento/images/Memento_diagram_4.png?raw=true)

***Implementation with even stricter encapsulation***

There’s another implementation which is useful when you don’t want to leave even the slightest chance of other classes accessing the state of the originator through the memento.

![](https://github.com/Venfurge/DesignPatterns/blob/Memento/images/Memento_diagram_5.png?raw=true)

## Pros and Cons

### Pros
 - You can produce snapshots of the object’s state without violating its encapsulation.
 - You can simplify the originator’s code by letting the caretaker maintain the history of the originator’s state.
### Cons
 - The app might consume lots of RAM if clients create mementos too often.
 - Caretakers should track the originator’s lifecycle to be able to destroy obsolete mementos.
 - Most dynamic programming languages, such as PHP, Python and JavaScript, can’t guarantee that the state within the memento stays untouched.

 ##
 Content from https://refactoring.guru/design-patterns/memento

 For more information follow the link above.
