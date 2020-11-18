using System.Collections.Generic;

namespace HomeWork2
{
    class Library
    {
        public readonly List<Book> ListBook = new List<Book>();

        public Library()
        {}

        public void AddBook(Book book)
        {
            this.ListBook.Add(book);
        }

        public Book CreateBook(string name, string author,  int price, FormatBook typeBook)
        {
            Book book = new Book(name, author, price, typeBook);
            this.AddBook(book);
            return book;
        }


    }
}
