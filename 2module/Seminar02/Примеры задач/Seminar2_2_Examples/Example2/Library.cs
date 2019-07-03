using System;

namespace Example2
{
    class Library
    {
        private static Random rnd;
        static Library()
        {
            rnd = new Random();
        }
        private Book GenerateNewBook(string name)
        {
            string text = string.Empty;
            for (int i = 0; i < 100; i++)
            {
                text += (char)rnd.Next(97, 144);
            }

            return new Book
            {
                Name = name,
                Page = rnd.Next(100),
                Text = text

            };
        }

        //Индексатор, отдающий книгу по ее названию.
        public Book this[string name] => GenerateNewBook(name);
    }
}