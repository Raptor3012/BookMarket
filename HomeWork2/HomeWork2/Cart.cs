using System.Collections.Generic;

namespace HomeWork2
{
    class Cart
    {
        private List<Book> ListBook = new List<Book>();

        public Cart()
        { }

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

        public int ApplyPromo(IPromo promo)
        {
           return promo.ApplyPromo();
        }
    }

    class FreeBook:IPromo
    {
        Book freebook;
        
        public FreeBook(Book book)
        {
            this.freebook = book;
        }

        public int ApplyPromo()
        {

            return 0;
        }
    }

}
