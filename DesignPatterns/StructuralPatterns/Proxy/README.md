
# Proxy

**Proxy** is a structural design pattern that lets you provide a substitute or placeholder for another object. A proxy controls access to the original object, allowing you to perform something either before or after the request gets through to the original object.

## Solution

The Proxy pattern suggests that you create a new proxy class with the same interface as an original service object. Then you update your app so that it passes the proxy object to all of the original object’s clients. Upon receiving a request from a client, the proxy creates a real service object and delegates all the work to it.

![](https://github.com/Venfurge/DesignPatterns/blob/Proxy/images/Proxy_diagram_2.png?raw=true)

But what’s the benefit? If you need to execute something either before or after the primary logic of the class, the proxy lets you do this without changing that class. Since the proxy implements the same interface as the original class, it can be passed to any client that expects a real service object.

## Structure

![](https://github.com/Venfurge/DesignPatterns/blob/Proxy/images/Proxy_diagram.png?raw=true)

## Pros and Cons

### Pros
 - You can control the service object without clients knowing about it
 - You can manage the lifecycle of the service object when clients don’t care about it.
 - The proxy works even if the service object isn’t ready or is not available.
 - Open/Closed Principle. You can introduce new proxies without changing the service or clients.
### Cons
 - The code may become more complicated since you need to introduce a lot of new classes.
 - The response from the service might get delayed.

 ##
 Content from https://refactoring.guru/design-patterns/proxy

 For more information follow the link above.
