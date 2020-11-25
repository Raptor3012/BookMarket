using System.Linq;

namespace HomeWork2
{
    class PaperDelivery : IStok
    {
        public PaperDelivery() { }
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
            double tempSum = 0;
            bool paperflag = false;
            foreach (var g in groupbyAuthorOrder)
            {
                foreach (var t in g.groupbyType)
                {
                    if (t.Nametype == FormatBook.paper && t.Count > 0)
                    {
                        paperflag = true;
                        foreach(var book in t.book)
                        {
                            tempSum += book.Price;
                        }
                    }
                }
                if (tempSum >= 1000 || paperflag==false)
                {
                   order.Delivery = 0;
                }
            }
        }
    }

}
