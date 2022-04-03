using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Mediator
{
    internal class ChatRoom : IChatRoom
    {
        private readonly Dictionary<string, Member> _members = new Dictionary<string, Member>();

        public void Register(Member member)
        {
            if (!_members.ContainsValue(member))
            {
                _members[member.MemberName] = member;
            }

            member.ChatRoom = this;
        }

        public void Send(string fromMember, string toMember, string message)
        {
            _members[fromMember].Receive(fromMember, message);
        }
    }
}
