namespace HomeWork2
{
    class Book
    {
        private string Name;
        private string Author;
        private FormatBook TypeBook;
        private int Price;

        public Book(string name, string author, FormatBook typeBook, int price)
        {
            Name = name;
            Author = author;
            TypeBook = typeBook;
            Price = price;
        }

        public int GetPrice()
        {
            int price = this.Price;
            return price;
        }
    }

    enum FormatBook
    {
        paper,
        fb2
    }
}
