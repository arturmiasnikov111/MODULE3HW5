using MODULE3HW5.Bridge.BookContentProvider;
using MODULE3HW5.Bridge.BookPublisher;
using MODULE3HW5.Bridge.Books;

namespace MODULE3HW5.Bridge
{
    public class BridgeStarter
    {
        public void Run()
        {
            IBookContentProvider contentProvider = new MyBookContentProvider();
            IBookContentProvider  oneMoreBook = new OneMoreBookCProvider();
            IBookPublisher publisher = new AudioBookPublisher();
            IBookPublisher digital = new DigitalBookPublisher();
            Book book = new Book(contentProvider, publisher);
            Book book1 = new Book(oneMoreBook, digital);
            book.PublishBook();
            book1.PublishBook();
        }
    }
}