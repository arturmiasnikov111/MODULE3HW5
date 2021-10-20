using System;
using System.Collections.Generic;
using System.Linq;

namespace MODULE3HW5.Bridge.BookPublisher
{
    public class DigitalBookPublisher : IBookPublisher
    {
        public void PublishBook(IEnumerable<string> bookContent)
        {
            Console.WriteLine($"Successfully printed book. ({bookContent.Count()} lines)");
        }
    }
}