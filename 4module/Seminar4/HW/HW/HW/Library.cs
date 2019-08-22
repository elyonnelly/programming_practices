using System;
using System.Collections;
using System.Collections.Generic;

namespace HW
{
    public class Library
    {
        List<Book> books;

        public Library(List<Book> books)
        {
            Books = books;
        }

        List<Book> Books
        {
            set
            {
                if (value == null) books = new List<Book>();
                books = value;
            }
        }
        public IEnumerator GetEnumerator()
        {
            return new LibraryEnumerator(this);
        }
        public class LibraryEnumerator : IEnumerator
        {
            List<Book> booksenum;

            int position = -1;

            public LibraryEnumerator(Library lib)
            {
                this.booksenum = lib.books;
            }

            public object Current => booksenum[position];

            public bool MoveNext()
            {
                if (position < booksenum.Count - 1)
                {
                    position++;
                    return true;
                }
                else
                    return false;
            }

            public void Reset()
            {
                position = -1;
            }
        }
        public event EventHandler<NewBookEventArgs> NewBook;
        public void Add(Book book)
        {
            books.Add(book);
            NewBook(this, new NewBookEventArgs(book));
        }
    }

}
