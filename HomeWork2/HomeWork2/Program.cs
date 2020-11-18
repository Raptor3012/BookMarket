using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace HomeWork2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.CreateBook("Анна Каренина", "Лев Толстой", 500, FormatBook.paper);
            library.CreateBook("Автостопом по галактике", "Дуглас Адамс", 1500, FormatBook.paper);
            library.CreateBook("Алиса в Стране чудес", "Льюис Кэрролл", 1500, FormatBook.paper);
            library.CreateBook("Алхимик", "Пауло Коэльо", 450, FormatBook.paper);
            library.CreateBook("Американский психопат", "Брет Истон Эллис", 600, FormatBook.paper);
            library.CreateBook("Аня из Зеленых Мезонинов", "Люси Мод Монтгомери", 700, FormatBook.paper);
            library.CreateBook("Ангус, ремни и конкретные обжимашки", "Луиз Рэннисон", 1500, FormatBook.paper);

            library.CreateBook("Анна Каренина", "Лев Толстой", 200, FormatBook.fb2);
            library.CreateBook("Автостопом по галактике", "Дуглас Адамс", 300, FormatBook.fb2);
            library.CreateBook("Алиса в Стране чудес", "Льюис Кэрролл", 200, FormatBook.fb2);
            library.CreateBook("Алхимик", "Пауло Коэльо", 150, FormatBook.fb2);
            library.CreateBook("Американский психопат", "Брет Истон Эллис", 300, FormatBook.fb2);
            library.CreateBook("Аня из Зеленых Мезонинов", "Люси Мод Монтгомери", 300, FormatBook.fb2);
            library.CreateBook("Ангус, ремни и конкретные обжимашки", "Луиз Рэннисон", 200, FormatBook.fb2);

            library.CreateBook("Гарри Поттер и кубок огня", "Джоан Роулинг", 1500, FormatBook.paper);
            library.CreateBook("Гарри Поттер и философский камень", "Джоан Роулинг", 1500, FormatBook.paper);
            library.CreateBook("Гарри Поттер и тайная комната", "Джоан Роулинг", 1500, FormatBook.paper);
            library.CreateBook("Гарри Поттер и узник Азкабана", "Джоан Роулинг", 1500, FormatBook.paper);

            library.CreateBook("Гарри Поттер и кубок огня", "Джоан Роулинг", 1000, FormatBook.fb2);
            library.CreateBook("Гарри Поттер и философский камень", "Джоан Роулинг", 1000, FormatBook.fb2);
            library.CreateBook("Гарри Поттер и тайная комната", "Джоан Роулинг", 1000, FormatBook.fb2);
            library.CreateBook("Гарри Поттер и узник Азкабана", "Джоан Роулинг", 1000, FormatBook.fb2);

            List<Book> pokupki = new List<Book>() { library.ListBook[1], library.ListBook[2], library.ListBook[3] };
            Cart cart1 = new Cart(pokupki);
           

            FreeBook freebook = new FreeBook(library.ListBook[2]);
            DiscountXPercent discX = new DiscountXPercent(10);

            cart1.ApplyPromo(freebook);
            cart1.ApplyPromo(discX);
            cart1.CalcPayment();
            Console.WriteLine(cart1.Cost);
            Console.WriteLine(cart1.CostWithDiscounts);

        }
    }
}
