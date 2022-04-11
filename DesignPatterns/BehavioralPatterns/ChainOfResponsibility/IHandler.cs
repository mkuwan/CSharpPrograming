using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    internal interface IHandler
    {
        IHandler SetNext(IHandler handler);

        string? Handle(RequestEvent request);
    }
}
