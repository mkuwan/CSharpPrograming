// See https://aka.ms/new-console-template for more information


using DesignPatterns.BehavioralPatterns.ChainOfResponsibility;
using DesignPatterns.BehavioralPatterns.Mediator;
using DesignPatterns.BehavioralPatterns.Observer;
using DesignPatterns.CreationalPatterns.AbstractFactory.RealCode.Drawing;
using DesignPatterns.CreationalPatterns.Builder.BuilderPattern;
using DesignPatterns.CreationalPatterns.Builder.FluentBuilder;


Console.WriteLine("AbstractFactoryCodeSample");
AbstractFactoryCodeSample abstractFactoryCodeSample = new AbstractFactoryCodeSample();
abstractFactoryCodeSample.Run();


Console.WriteLine("FluentBuilderSample");
FluentBuilderSample fluentBuilderSample = new FluentBuilderSample();
fluentBuilderSample.Run();

Console.WriteLine("Builder Pattern Sample");
BuildHouseSample buildHouseSample = new BuildHouseSample();
buildHouseSample.Run();

Console.WriteLine("Mediator Pattern Sample");
ChatRoomSample chatRoomSample = new ChatRoomSample();
chatRoomSample.Run();

Console.WriteLine("Observer Pattern Sample");
ObserverSample observerSample = new ObserverSample();
observerSample.Run();

Console.WriteLine("Chain of Responsibility Sample");
Console.WriteLine("Only A");
var eventA = new EventA();
ChainClient.Run(eventA);

Console.WriteLine("A -> B");
var eventB = new EventB();
eventA.SetNext(eventB);
ChainClient.Run(eventA);

Console.WriteLine("A -> B -> C");
var eventC = new EventC();
eventA.SetNext(eventB).SetNext(eventC);
ChainClient.Run(eventA);

Console.ReadKey();
