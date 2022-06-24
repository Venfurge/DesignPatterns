
# Iterator

**Iterator** is a behavioral design pattern that lets you traverse elements of a collection without exposing its underlying representation (list, stack, tree, etc.).

## Solution

The main idea of the Iterator pattern is to extract the traversal behavior of a collection into a separate object called an iterator.

![](https://github.com/Venfurge/DesignPatterns/blob/Iterator/images/Iterator_diagram_2.png?raw=true)

In addition to implementing the algorithm itself, an iterator object encapsulates all of the traversal details, such as the current position and how many elements are left till the end. Because of this, several iterators can go through the same collection at the same time, independently of each other.

Usually, iterators provide one primary method for fetching elements of the collection. The client can keep running this method until it doesn’t return anything, which means that the iterator has traversed all of the elements.

All iterators must implement the same interface. This makes the client code compatible with any collection type or any traversal algorithm as long as there’s a proper iterator. If you need a special way to traverse a collection, you just create a new iterator class, without having to change the collection or the client.

## Structure

![](https://github.com/Venfurge/DesignPatterns/blob/Iterator/images/Iterator_diagram.png?raw=true)

## Pros and Cons

### Pros
 - Single Responsibility Principle. You can clean up the client code and the collections by extracting bulky traversal algorithms into separate classes.
 - Open/Closed Principle. You can implement new types of collections and iterators and pass them to existing code without breaking anything.
 - You can iterate over the same collection in parallel because each iterator object contains its own iteration state.
 - For the same reason, you can delay an iteration and continue it when needed.
 ### Cons
 - Applying the pattern can be an overkill if your app only works with simple collections.
 - Using an iterator may be less efficient than going through elements of some specialized collections directly.

 ##
 Content from https://refactoring.guru/design-patterns/iterator

 For more information follow the link above.
