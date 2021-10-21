namespace MODULE3HW5.Mediator
{
    public class MediatorStarter
    {
        public void Run()
        {
            var chat = new ChatMediator();
            var nick = new User(chat, "Nick");
            var jack = new User(chat, "Jack");
            var marina = new User(chat, "Marina");
            
            chat.AddUser(nick);
            //chat.AddUser(jack);
            chat.AddUser(marina);
            chat.WhoInChat();
            chat.AddUser(jack);
            chat.AddUser(marina);
            nick.SendMessage("hello how are you?");
            jack.SendMessage($"hello from {jack.Nickname}");
            marina.SendMessage($"Hello from {marina.Nickname}");
        }
    }
}