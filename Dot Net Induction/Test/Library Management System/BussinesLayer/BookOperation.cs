using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
namespace BussinesLayer
{
    public static class BookOperation
    {
        public static bool DeleteBook(string name)
        {
            return DataLayer.BookDbOperation.DeleteBook(name);
        }
        public static List<Book> GetAllBooks()
        {
            
            List<DataLayer.Book> dbBooks = BookDbOperation.GetAllBooks();
            List<Book> books = new List<Book>();
            foreach (DataLayer.Book book in dbBooks)
            {
                Book tempBook = new Book();
                tempBook.Name = book.Name;
                tempBook.Author = book.Author;
                tempBook.Quantity = book.Quantity.Value;
                books.Add(tempBook);
            }
            return books;
        }
        public static void UpdateBook(Book book)
        {
            DataLayer.Book dbBook= new DataLayer.Book();
            dbBook.Name = book.Name;
            dbBook.Author = book.Author;
            dbBook.Quantity = book.Quantity;
            DataLayer.BookDbOperation.UpdateBook(dbBook);
        }
        public static void Add(Book book)
        {
            DataLayer.Book dbBook = new DataLayer.Book();
            dbBook.Name = book.Name;
            dbBook.Author = book.Author;
            dbBook.Quantity = book.Quantity;
            BookDbOperation.Add(dbBook);
        }
    }
}
