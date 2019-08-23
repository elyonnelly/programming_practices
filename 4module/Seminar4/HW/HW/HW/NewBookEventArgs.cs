using System;

namespace HW
{
    public class NewBookEventArgs:EventArgs
    {
        public Book book;

        public NewBookEventArgs(Book book)
        {
            this.book = book;
        }
    }
}