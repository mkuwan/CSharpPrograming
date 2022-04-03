using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Mediator
{
    internal class RegularMember : Member
    {
        public RegularMember(string memberName) : base(memberName)
        {
        }

        public override void Receive(string @from, string message)
        {
            Console.WriteLine("Regular Member");
            base.Receive(@from, message);
        }
    }
}
