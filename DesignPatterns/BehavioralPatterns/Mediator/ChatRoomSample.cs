using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.Mediator
{
    internal class ChatRoomSample
    {
        public void Run()
        {
            IChatRoom chatRoom = new ChatRoom();

            Member Suzuki = new RegularMember("鈴木");
            Member Kimura = new RegularMember("木村");
            Member Guest = new GuestMember("ゲスト");

            chatRoom.Register(Suzuki);
            chatRoom.Register(Kimura);
            chatRoom.Register(Guest);

            Suzuki.Send(Kimura.MemberName, "鈴木から木村へのメッセージ");
            Kimura.Send(Suzuki.MemberName, "木村から鈴木へのメッセージ");
            Suzuki.Send(Guest.MemberName, "鈴木からゲストへのメッセージ");
            Guest.Send(Kimura.MemberName, "ゲストから木村へのメッセージ");


        }
    }
}
