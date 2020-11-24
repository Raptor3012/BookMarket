using System.Collections.Generic;

namespace HomeWork2
{
    class FreeBook :IPromo
    {
        Book freebook;
        
        public FreeBook(Book book)
        {
            this.freebook = book;
        }

        public void ApplyPromo(Order order)
        {
            if (order.ListBook.Contains(this.freebook))
            {
                order.Discount += freebook.Price;
            }            
        }
    }
}
