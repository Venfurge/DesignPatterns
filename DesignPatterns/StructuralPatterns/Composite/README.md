
# Composite

**Composite** is a structural design pattern that lets you compose objects into tree structures and then work with these structures as if they were individual objects.

## Solution

The Composite pattern suggests that you work with Products and Boxes through a common interface which declares a method for calculating the total price.

How would this method work? For a product, it’d simply return the product’s price. For a box, it’d go over each item the box contains, ask its price and then return a total for this box. If one of these items were a smaller box, that box would also start going over its contents and so on, until the prices of all inner components were calculated. A box could even add some extra cost to the final price, such as packaging cost.

![](https://github.com/Venfurge/DesignPatterns/blob/Composite/images/Composite_diagram_2.png?raw=true)

The greatest benefit of this approach is that you don’t need to care about the concrete classes of objects that compose the tree. You don’t need to know whether an object is a simple product or a sophisticated box. You can treat them all the same via the common interface. When you call a method, the objects themselves pass the request down the tree.

## Structure

![](https://github.com/Venfurge/DesignPatterns/blob/Composite/images/Composite_diagram.png?raw=true)

## Pros and Cons

### Pros
 - You can work with complex tree structures more conveniently: use polymorphism and recursion to your advantage.
 - Open/Closed Principle. You can introduce new element types into the app without breaking the existing code, which now works with the object tree.
### Cons
 - It might be difficult to provide a common interface for classes whose functionality differs too much. In certain scenarios, you’d need to overgeneralize the component interface, making it harder to comprehend.

 ##
 Content from https://refactoring.guru/design-patterns/composite

 For more information follow the link above.
