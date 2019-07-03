namespace Example2
{
    /// <summary>
    /// В Волшебном мире все библиотеки бесконечны и в них есть абсолютно любые книги.
    /// Принесены в библиотеку они были давным давно, и сейчас в библиотеку уже нельзя добавлять
    /// новых книг.
    /// Но вы можете брать оттуда любые книги.
    /// Правда, иногда они написаны на эльфийском или других языках... И в целом библиотека --
    /// очень непредсказуема...
    /// </summary>

    class Book
    {
        public string Name { get; set; }
        public int Page { get; set; }
        public string Text { get; set; }

        public string GetInfo()
        {
            return $"Book {Name};\nPage: {Page}\nText: {Text}";
        }
    }
}