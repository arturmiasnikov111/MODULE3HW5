using System.Collections.Generic;
using MODULE3HW5.Bridge.Abstraction;
using MODULE3HW5.Bridge.BookContentProvider;
using MODULE3HW5.Bridge.BookPublisher;

namespace MODULE3HW5.Bridge.Books
{
    public class Book : IBook
    {
                
        private readonly IBookContentProvider _contentProvider;
        private readonly IBookPublisher _publisher;
        
        public Book(IBookContentProvider contentProvider, IBookPublisher publisher)
        {
            _contentProvider = contentProvider;
            _publisher = publisher;
        }
        
        public void PublishBook()
        {
            IEnumerable<string> bookContent = _contentProvider.GetContent();
            
            _publisher.PublishBook(bookContent);
        }
    }
}