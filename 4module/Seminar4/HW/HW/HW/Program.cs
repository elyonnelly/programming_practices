using System;

namespace HW
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Library MyLibrary = new Library(Randomize.RandomBooks());
            MyLibrary.NewBook += (object sender, NewBookEventArgs e) =>
            {
                Console.WriteLine($"Added new book: {e.book}");
            };
            foreach (var item in MyLibrary)
            {
                Console.WriteLine(item);
            }
            MyLibrary.Add(Randomize.RandomBook());
            Console.Read();
        }


    }
}
