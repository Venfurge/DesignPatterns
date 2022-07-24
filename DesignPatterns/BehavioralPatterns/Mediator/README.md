
# Mediator

**Mediator** is a behavioral design pattern that lets you reduce chaotic dependencies between objects. The pattern restricts direct communications between the objects and forces them to collaborate only via a mediator object.

## Solution

The Mediator pattern suggests that you should cease all direct communication between the components which you want to make independent of each other. Instead, these components must collaborate indirectly, by calling a special mediator object that redirects the calls to appropriate components. As a result, the components depend only on a single mediator class instead of being coupled to dozens of their colleagues.

In our example with the profile editing form, the dialog class itself may act as the mediator. Most likely, the dialog class is already aware of all of its sub-elements, so you won’t even need to introduce new dependencies into this class.

![](https://github.com/Venfurge/DesignPatterns/blob/Mediator/images/Mediator_diagram_2.png?raw=true)

The most significant change happens to the actual form elements. Let’s consider the submit button. Previously, each time a user clicked the button, it had to validate the values of all individual form elements. Now its single job is to notify the dialog about the click. Upon receiving this notification, the dialog itself performs the validations or passes the task to the individual elements. Thus, instead of being tied to a dozen form elements, the button is only dependent on the dialog class.

You can go further and make the dependency even looser by extracting the common interface for all types of dialogs. The interface would declare the notification method which all form elements can use to notify the dialog about events happening to those elements. Thus, our submit button should now be able to work with any dialog that implements that interface.

This way, the Mediator pattern lets you encapsulate a complex web of relations between various objects inside a single mediator object. The fewer dependencies a class has, the easier it becomes to modify, extend or reuse that class.

## Structure

![](https://github.com/Venfurge/DesignPatterns/blob/Mediator/images/Mediator_diagram.png?raw=true)

## Pros and Cons

### Pros
 - Single Responsibility Principle. You can extract the communications between various components into a single place, making it easier to comprehend and maintain.
 - Open/Closed Principle. You can introduce new mediators without having to change the actual components.
 - You can reduce coupling between various components of a program.
 - You can reuse individual components more easily.
### Cons
 - Over time a mediator can evolve into a God Object.

 ##
 Content from https://refactoring.guru/design-patterns/mediator

 For more information follow the link above.
