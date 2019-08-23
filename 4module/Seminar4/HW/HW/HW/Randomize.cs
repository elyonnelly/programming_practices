using System;
using System.Collections.Generic;

namespace HW
{
    public static class Randomize
    {
        public static Random rnd = new Random();
        static int IdForBook = 1;
        public static string RandonString()
        {
            int rand = rnd.Next(5, 20);
            string line = "";
            line += (char)rnd.Next('A', 'Z');
            for (int i = 0; i < rand; i++)
            {
                line += (char)rnd.Next('a', 'z');
            }
            return line;
        }

        public static List<Book> RandomBooks()
        {
            List<Book> rndbooks = new List<Book>();
            int rand = rnd.Next(3, 10);
            for (int i = 0; i < rand; i++)
            {
                rndbooks.Add(new Book(IdForBook++, RandonString(), RandonString()));
            }
            return rndbooks;
        }
        public static Book RandomBook()
        {
            return new Book(IdForBook++, RandonString(), RandonString());
        }
    }

}
