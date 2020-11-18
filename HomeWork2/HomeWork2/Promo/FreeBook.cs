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

        public void ApplyPromo(Cart cart)
        {
            if (cart.ListBook.Contains(this.freebook))
            {
                cart.CostWithDiscounts -= freebook.Price;
            }            
        }
    }
}
