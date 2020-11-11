using System.Collections.Generic;

namespace HomeWork2
{
    class Cart
    {
        private List<Book> ListBook = new List<Book>();

        public Cart()
        {}

        public void AddBook(Book book)
        {
            this.ListBook.Add(book);
        }

        public int CalcPayment()
        {
            int result = 0;
            foreach (Book book in this.ListBook)
            {
                result += book.GetPrice();
            }



            return 0;
        }






    }


}
