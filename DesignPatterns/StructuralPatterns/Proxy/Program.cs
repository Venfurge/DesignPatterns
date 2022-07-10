// See https://aka.ms/new-console-template for more information
using Proxy.models;

RealSubject realSubject = new RealSubject();
Client client = new Client(realSubject);
client.RunClientCode();

Console.WriteLine("Using proxy agains real object");

ProxySubject proxySubject = new ProxySubject(realSubject);
client = new Client(proxySubject);
client.RunClientCode();