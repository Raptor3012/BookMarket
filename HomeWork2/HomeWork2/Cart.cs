using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork2
{
    class Cart
    {
        private readonly Order Order;
        private List<IPromo> ListPromo = new List<IPromo>();
        private List<IStok> ListStok = new List<IStok>();

        public Cart(List<Book> listBook)
        {
            this.Order = new Order(listBook);           
        }

        public void ApplyPromo(IPromo promo)
        {
            this.ListPromo.Add(promo);
        }

        public void ApplyStok(IStok stok)
        {
            this.ListStok.Add(stok);
        }

        public void PrintContentCart()
        {
            var groupbyAuthor = from book in this.Order.ListBook
                                     group book by book.Author into groupautor
                                     select new
                                     {
                                         Author = groupautor.Key,
                                         groupbyType = from book in groupautor
                                                       group book by book.TypeBook into grouptype
                                                       select new
                                                       {
                                                           Nametype = grouptype.Key,
                                                           Count = grouptype.Count(),
                                                           book = from book in grouptype select book
                                                       }
                                     };
            foreach (var g in groupbyAuthor)
            {
                Console.WriteLine(g.Author);
                foreach (var t in g.groupbyType)
                {

                    Console.WriteLine($"{t.Nametype} : {t.Count}");
                    foreach (var book in t.book)
                    {
                        Console.WriteLine("     " + book.Name);
                    }
                }
                Console.WriteLine();
            }
        }

        public double CalcPayment()
        {
            foreach (var promo in this.ListPromo)
            {
               promo.ApplyPromo(this.Order);
            }

            foreach (var promo in this.ListStok)
            {
                promo.ApplyStok(this.Order);
            }
            double result = this.Order.TotalCost;
            Console.WriteLine($"Цена { Order.Cost}");
            Console.WriteLine($"Доставка { Order.Delivery}");
            Console.WriteLine($"Скидка { Order.Discount}");
            Console.WriteLine($"Итого { result}");

            return result;
        }

        
    }

}
