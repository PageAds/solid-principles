using System;

namespace SingleReponsibility.GoodWay
{
    /// <summary>
    /// Responsibility of this class = Managing Books
    /// </summary>
    public class BookStore
    {
        private FileLogger fileLogger = new FileLogger();

        public void AddBook(Book book)
        {
            var bookRepository = new BookRepository();
            
            try
            {
                bookRepository.Add(book);
            }
            catch (System.Exception ex)
            {
                // The file logging implementation code has been extracted into a seperate class
                // This means if this code ever changes then this class does not need to change along with it
                this.fileLogger.Log(ex.Message);
            }
        }
    }
}
