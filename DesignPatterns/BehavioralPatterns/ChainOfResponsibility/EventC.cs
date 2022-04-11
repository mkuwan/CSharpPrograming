using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    internal class EventC: AbstractHandler
    {
        public override string? Handle(RequestEvent request)
        {
            if (request.EventId == "C")
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
