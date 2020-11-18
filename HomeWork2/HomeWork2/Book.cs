namespace HomeWork2
{
    class Book
    {
        public readonly string Name;
        public readonly string Author;
        public readonly int Price;
        public readonly FormatBook TypeBook;

        public Book(string name, string author, int price, FormatBook typeBook)
        {
            Name = name;
            Author = author;
            Price = price;
            TypeBook = typeBook;
        }
    }

    enum FormatBook
    {
        paper,
        fb2
    }
}
