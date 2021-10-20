using System.Collections;
using System.Collections.Generic;

namespace MODULE3HW5.Bridge.BookContentProvider
{
    public interface IBookContentProvider
    {
        IEnumerable<string> GetContent();
    }
}