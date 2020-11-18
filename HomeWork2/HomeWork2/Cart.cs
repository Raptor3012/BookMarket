using System.Collections.Generic;

namespace HomeWork2
{
    class Cart
    {
        public readonly List<Book> ListBook;
        public readonly double Cost;
        public double CostWithDiscounts;
        private List<IPromo> ListPromo = new List<IPromo>();
        private int Delivery;


        public Cart(List<Book> listBook)
        {
            this.ListBook = listBook;
            this.Cost = 0;
            this.CostWithDiscounts = 0;
            this.Delivery = 200;
            foreach (Book book in listBook)
            {
                this.Cost += book.Price;
            }
        }

        public void ApplyPromo(IPromo promo)
        {
            this.ListPromo.Add(promo);
        }

        public void CalcPayment()
        {
            this.CostWithDiscounts = this.Cost;
            foreach (var promo in this.ListPromo)
            {
               promo.ApplyPromo(this);
            }
                

        }

        
    }

}
