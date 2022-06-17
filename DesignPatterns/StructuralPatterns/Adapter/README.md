
# Adapter

**Adapter** is a structural design pattern that allows objects with incompatible interfaces to collaborate.

## Solution

![](https://github.com/Venfurge/DesignPatterns/blob/Adapter/images/Adapter_diagram_2.png?raw=true)

You can create an adapter. This is a special object that converts the interface of one object so that another object can understand it.

An adapter wraps one of the objects to hide the complexity of conversion happening behind the scenes. The wrapped object isn’t even aware of the adapter. For example, you can wrap an object that operates in meters and kilometers with an adapter that converts all of the data to imperial units such as feet and miles.

Adapters can not only convert data into various formats but can also help objects with different interfaces collaborate. Here’s how it works:
    
    1. The adapter gets an interface, compatible with one of the existing objects.
    2. Using this interface, the existing object can safely call the adapter’s methods.
    3. Upon receiving a call, the adapter passes the request to the second object, 
       but in a format and order that the second object expects.
    
Sometimes it’s even possible to create a two-way adapter that can convert the calls in both directions.

![](https://github.com/Venfurge/DesignPatterns/blob/Adapter/images/Adapter_diagram_3.png?raw=true)

Let’s get back to our stock market app. To solve the dilemma of incompatible formats, you can create XML-to-JSON adapters for every class of the analytics library that your code works with directly. Then you adjust your code to communicate with the library only via these adapters. When an adapter receives a call, it translates the incoming XML data into a JSON structure and passes the call to the appropriate methods of a wrapped analytics object.

## Structure

**Object adapter**

This implementation uses the object composition principle: the adapter implements the interface of one object and wraps the other one. It can be implemented in all popular programming languages.

![](https://github.com/Venfurge/DesignPatterns/blob/Adapter/images/Adapter_diagram(1).png?raw=true)

**Class adapter**

This implementation uses inheritance: the adapter inherits interfaces from both objects at the same time. Note that this approach can only be implemented in programming languages that support multiple inheritance, such as C++.

![](https://github.com/Venfurge/DesignPatterns/blob/Adapter/images/Adapter_diagram(2).png?raw=true)

## Pros and Cons

### Pros
 - Single Responsibility Principle. You can separate the interface or data conversion code from the primary business logic of the program.
 - Open/Closed Principle. You can introduce new types of adapters into the program without breaking the existing client code, as long as they work with the adapters through the client interface.
 ### Cons
 - The overall complexity of the code increases because you need to introduce a set of new interfaces and classes. Sometimes it’s simpler just to change the service class so that it matches the rest of your code.

 ##
 Content from https://refactoring.guru/design-patterns/adapter

 For more information follow the link above.
