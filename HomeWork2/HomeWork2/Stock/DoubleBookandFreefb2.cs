using System;
using System.Linq;

namespace HomeWork2
{
    class DoubleBookandFreefb2 : IStok
    {

        public DoubleBookandFreefb2()
        {
        }

        public void ApplyStok(Order order)
        {
            var groupbyAuthorOrder = from book in order.ListBook
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
            foreach (var g in groupbyAuthorOrder)
            {
                bool flagpaper = false;
                foreach (var t in g.groupbyType)
                {
                    if (t.Nametype == FormatBook.paper && t.Count >= 2 )
                    {
                        flagpaper = true;
                    }
                }
                if (flagpaper)
                {
                    foreach (var t in g.groupbyType)
                    {
                        if (t.Nametype == FormatBook.fb2 && t.Count >= 1)
                        {
                            order.Discount += t.book.Last().Price;
                        }
                    }
                }
            }
        }
    }

}
