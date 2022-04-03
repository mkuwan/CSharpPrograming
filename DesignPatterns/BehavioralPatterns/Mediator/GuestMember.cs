using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Mediator
{
    internal class GuestMember : Member
    {
        public GuestMember(string memberName) : base(memberName)
        {
        }

        public override void Receive(string @from, string message)
        {
            Console.WriteLine("Guest Member");
            base.Receive(@from, message);
        }
    }
}
