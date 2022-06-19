
# Template Method

**Template Method** is a behavioral design pattern that defines the skeleton of an algorithm in the superclass but lets subclasses override specific steps of the algorithm without changing its structure.


## Solution

![](https://github.com/Venfurge/DesignPatterns/blob/TemplateMethod/images/Template_Method_diagram_2.png?raw=true)

The Template Method pattern suggests that you break down an algorithm into a series of steps, turn these steps into methods, and put a series of calls to these methods inside a single template method. The steps may either be abstract, or have some default implementation. To use the algorithm, the client is supposed to provide its own subclass, implement all abstract steps, and override some of the optional ones if needed (but not the template method itself).

Let’s see how this will play out in our data mining app. We can create a base class for all three parsing algorithms. This class defines a template method consisting of a series of calls to various document-processing steps.

![](https://github.com/Venfurge/DesignPatterns/blob/TemplateMethod/images/Template_Method_diagram_3.png?raw=true)

At first, we can declare all steps abstract, forcing the subclasses to provide their own implementations for these methods. In our case, subclasses already have all necessary implementations, so the only thing we might need to do is adjust signatures of the methods to match the methods of the superclass.

Now, let’s see what we can do to get rid of the duplicate code. It looks like the code for opening/closing files and extracting/parsing data is different for various data formats, so there’s no point in touching those methods. However, implementation of other steps, such as analyzing the raw data and composing reports, is very similar, so it can be pulled up into the base class, where subclasses can share that code.

As you can see, we’ve got two types of steps:

- abstract steps must be implemented by every subclass
- optional steps already have some default implementation, but still can be overridden if needed

There’s another type of step, called hooks. A hook is an optional step with an empty body. A template method would work even if a hook isn’t overridden. Usually, hooks are placed before and after crucial steps of algorithms, providing subclasses with additional extension points for an algorithm.

## Structure

![](https://github.com/Venfurge/DesignPatterns/blob/TemplateMethod/images/Template_Method_diagram.png?raw=true)

## Pros and Cons

### Pros
 - You can let clients override only certain parts of a large algorithm, making them less affected by changes that happen to other parts of the algorithm.
 - You can pull the duplicate code into a superclass.
 ### Cons
 - Some clients may be limited by the provided skeleton of an algorithm.
 - You might violate the Liskov Substitution Principle by suppressing a default step implementation via a subclass.
 - Template methods tend to be harder to maintain the more steps they have.

 ##
 Content from https://refactoring.guru/design-patterns/template-method

 For more information follow the link above.
