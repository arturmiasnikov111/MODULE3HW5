namespace MODULE3HW5.Mediator.Abstraction
{
    public interface IChat
    {
        void SendMessage(string message, User user);

        void AddUser(User user);

        void WhoInChat();
    }
}