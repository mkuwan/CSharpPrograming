using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Mediator
{
    internal abstract class Member
    {
        public IChatRoom ChatRoom { get; set; }

        public string MemberName { get; }


        protected Member(string memberName)
        {
            MemberName = memberName;
        }


        public void Send(string to, string message)
        {
            this.ChatRoom.Send(MemberName, to, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"Message Received: from{from}, message:{message}");
        }
    }
}
