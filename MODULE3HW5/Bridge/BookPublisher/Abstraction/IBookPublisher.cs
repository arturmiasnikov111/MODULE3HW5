using System.Collections;
using System.Collections.Generic;

namespace MODULE3HW5.Bridge.BookPublisher
{
    public interface IBookPublisher
    {
        void PublishBook(IEnumerable<string> bookContent);
    }
}