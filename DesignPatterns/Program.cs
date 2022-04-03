// See https://aka.ms/new-console-template for more information


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



Console.ReadKey();
