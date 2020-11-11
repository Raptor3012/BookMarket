using System.Collections.Generic;

namespace HomeWork2
{
    class Library
    {
        private HashSet<Book> ListBook = new HashSet<Book>();

        public Library()
        {}

        public void AddBook(Book book)
        {
            this.ListBook.Add(book);
        }

        public Book CreateBook(string name, string author, FormatBook typeBook, int price)
        {
            Book book = new Book(name, author, typeBook, price);
            this.AddBook(book);
            return book;
        }


    }
}
