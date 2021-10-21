using System;
using MODULE3HW5.Mediator.Abstraction;

namespace MODULE3HW5.Mediator
{
    public class User
    {
        public string Nickname { get; }
        public IChat ChatRoom { get; }

        public User(IChat chatRoom, string nick)
        {
            Nickname = nick;
            ChatRoom = chatRoom;
        }

        public void PrintMessage(string message, User user)
        {
            Console.WriteLine();
            Console.WriteLine($"{user.Nickname} sent to {Nickname} {Environment.NewLine} --- {message}");
            Console.WriteLine();
        }

        public void SendMessage(string message)
        {
            ChatRoom.SendMessage(message, this);
        }
    }
}