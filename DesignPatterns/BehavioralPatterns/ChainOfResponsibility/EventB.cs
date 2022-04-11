using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    internal class EventB: AbstractHandler
    {
        public override string? Handle(RequestEvent request)
        {
            if (request.EventId == "B")
            {
                return request.EventName;
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
