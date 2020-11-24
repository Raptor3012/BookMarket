using System;
using System.Collections.Generic;

namespace HomeWork2
{
    class Order
    {
        public readonly List<Book> ListBook;
        public readonly double Cost;
        public double Discount;
        public int Delivery;

        public Order(List<Book> listbook)
        {
            this.ListBook = listbook;
            foreach (Book book in this.ListBook)
            {
                this.Cost += book.Price;
                this.Discount = 0;
                this.Delivery = 200;
            }
        }

        public double TotalCost => Math.Max(Cost - Discount, 0);
    }

    class Cart
    {
        private readonly Order Order;
        private List<IPromo> ListPromo = new List<IPromo>(); 

        public Cart(List<Book> listBook)
        {
            this.Order = new Order(listBook);           
        }

        public void ApplyPromo(IPromo promo)
        {
            this.ListPromo.Add(promo);
        }

        public double CalcPayment()
        {
            foreach (var promo in this.ListPromo)
            {
               promo.ApplyPromo(this.Order);
            }


            Console.WriteLine(Order.Delivery);
            double result = this.Order.TotalCost;
            return result;
        }

        
    }

}
