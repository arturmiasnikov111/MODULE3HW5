using System;
using System.Collections.Generic;
using System.Linq;
using MODULE3HW5.Mediator.Abstraction;

namespace MODULE3HW5.Mediator
{
    public class ChatMediator : IChat
    {
        private readonly List<User> _usersInChat;

        public ChatMediator()
        {
            _usersInChat = new List<User>();
        }
 
        public void AddUser(User user)
        {
            if (!_usersInChat.Contains(user))
            {
                _usersInChat.Add(user);
            }
            else
            {
                Console.WriteLine($"user with this Nickname {user.Nickname} already in chat");
            }
        }

        public void SendMessage(string message, User me)
        {
            if (_usersInChat.Contains(me))
            {
                _usersInChat.Where(u => u != me)
                    .ToList()
                    .ForEach(e => e.PrintMessage(message, me));
                Console.WriteLine("------------------");
            }
            else
            {
                Console.WriteLine($"{me.Nickname} not in chat");
                Console.WriteLine("------------------");
            }
        }

        public void WhoInChat()
        {
            Console.WriteLine($"Total users in Chat {_usersInChat.Count}");
            foreach (var user in _usersInChat)
            {
                Console.WriteLine($"- {user.Nickname}");
            }
        }
    }
}