using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    internal class ChainClient
    {
        public static void Run(AbstractHandler handler)
        {
            foreach (var requestEvent in new List<RequestEvent>{ new RequestEvent("A", "イベントA"), new RequestEvent("B", "イベントB"), new RequestEvent("C", "イベントC")})
            {
                Console.WriteLine($"ChainClient: EventId = {requestEvent.EventId}");

                var result = handler.Handle(requestEvent);

                if (result != null)
                {
                    Console.WriteLine($"Event Name is {result}");
                }
                else
                {
                    Console.WriteLine("イベントをハンドルできませんでした");
                }
            }
        }
    }
}
