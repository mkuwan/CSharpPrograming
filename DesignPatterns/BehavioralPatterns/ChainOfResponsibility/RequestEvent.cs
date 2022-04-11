using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    internal class RequestEvent
    {
        public string? EventId;
        public string? EventName;

        public RequestEvent(string eventId, string eventName)
        {
            EventId = eventId;
            EventName = eventName;
        }
    }
}
