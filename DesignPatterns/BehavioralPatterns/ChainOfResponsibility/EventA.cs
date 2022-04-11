using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    internal class EventA: AbstractHandler
    {
        public override string? Handle(RequestEvent request)
        {
            if (request.EventId == "A")
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
