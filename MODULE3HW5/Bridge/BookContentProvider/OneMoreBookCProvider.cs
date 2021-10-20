using System.Collections.Generic;

namespace MODULE3HW5.Bridge.BookContentProvider
{
    public class OneMoreBookCProvider : IBookContentProvider
    {
        public IEnumerable<string> GetContent()
        {
            return new List<string>()
            {
                "Hello",
                "Bye",
                "Hello",
                "4"
            };
        }
    }
}