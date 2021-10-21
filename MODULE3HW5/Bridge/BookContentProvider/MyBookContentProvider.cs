using System.Collections.Generic;

namespace MODULE3HW5.Bridge.BookContentProvider
{
    public class MyBookContentProvider : IBookContentProvider
    {
        public IEnumerable<string> GetContent()
        {
            return new List<string>()
            {
                "Hello",
                "H1111",
                "asd"
            };
        }
    }
}