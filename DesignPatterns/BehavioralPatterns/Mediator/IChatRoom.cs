using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Mediator
{
    internal interface IChatRoom
    {
        void Register(Member member);
        void Send(string fromMember, string toMember, string message);
    }
}
