using System;
using System.IO;

namespace SingleReponsibility.BadWay
{
    /// <summary>
    /// Responsibility of this class = Managing Books
    /// </summary>
    public class BookStore
    {
        /// <summary>
        /// This method is doing too much than what it is responsible for...
        /// 1 - Adding a book (Managing Books)
        /// 2 - Explicit logging implementation when an exception is caught
        /// </summary>
        /// <param name="book"></param>
        public void AddBook(Book book)
        {
            var bookRepository = new BookRepository();
            
            try
            {
                bookRepository.Add(book);
            }
            catch (System.Exception ex)
            {
                // A class should only ever have "one reason to change"
                // If our file logging implementation below were to change, then this class would have to change
                File.WriteAllText(@"C:\Temp\logger.txt", ex.Message);
            }
        }
    }
}