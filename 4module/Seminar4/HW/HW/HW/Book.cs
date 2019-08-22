using System;

namespace HW
{
    public class Book
    {
        int id;
        int Id
        {
            set
            {
                if (value <= 0) throw new ArgumentException("id целое положительное число");
                id = value;
            }
        }
        string name;
        public string Name
        {
            get => name;
            private set
            {
                if (value.Length > 40) throw new ArgumentException("длина названия книги не должна превышать 40 символов");
                name = value;
            }
        }
        string author;

        public Book(int id, string name, string author)
        {
            Id = id;
            Name = name;
            Author = author;
        }

        public string Author
        {
            get => author;
            private set
            {
                if (value.Length > 25) throw new ArgumentException("длина имени автора не должна превышать 25 символов");
                author = value;
            }
        }
        public override string ToString() => $"{id}, {Name}, {Author}";


    }
}
