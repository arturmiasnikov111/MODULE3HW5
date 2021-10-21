using System;
using MODULE3HW5.Bridge;
using MODULE3HW5.Bridge.Abstraction;
using MODULE3HW5.Bridge.BookContentProvider;
using MODULE3HW5.Bridge.BookPublisher;
using MODULE3HW5.Bridge.Books;
using MODULE3HW5.Mediator;

namespace MODULE3HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new MediatorStarter();
            mediator.Run();

            var bridge = new BridgeStarter();
            bridge.Run();
            
        }
    }
}