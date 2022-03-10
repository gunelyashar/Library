using System;

namespace Libraryupd
{
    class Program
    {
        static void NewStruct
            class Library
        {
            public string name;
            public List<Book> books = new List<Book>();

            public string ID { get; private set; }

            public void addBook(string title, string author)
            {
                int bookQuantity;

                string btitle;
                string bauthor;

                bookQuantity = int.Parse(Console.ReadLine());

                for (int x = 0; x <= bookQuantity; x++)
                {
                    Console.WriteLine("Enter Title:");
                    btitle = Console.ReadLine();

                    Console.WriteLine("Enter Author:");
                    bauthor = Console.ReadLine();

                    books.Add(new Book(btitle, bauthor));
                }
            }

            public void findBook()
            {
                var obj = new Book();
                ID = "xy";
                string id = obj.ID;

                Book result = books.Find(x => ID == "xy");
            }

            public void displayBooks()
            {
                foreach (Book b in Library.books)
                {
                    Console.WriteLine(b.ToString());
                }
            }

            public void removeBook()
            {

            }

            public Library()
            {

            }
        }

        public class Book
        {
            public string title;
            public string author;
            public int id;
            static int isbn;

            public string ID { get; set; }

            public void assignID()
            {
                id = isbn;
                isbn++;
            }

            public Book(string title, string author)
            {
                this.title = title;
                this.author = author;
            }

            public Book()
            {
            }

            public override string ToString()
            {
                return string.Format("Title: " + title, "\nAuthor: " + author, "\nISBN: " + id);
            }
        }
    }

    public class List<T>
    {
        internal void Add(Program.Book book)
        {
            throw new NotImplementedException();
        }

        internal Program.Book Find(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }

    internal struct NewStruct
    {
        public string[] Item1;
        public object Item2;

        public NewStruct(string[] item1, object item2)
        {
            Item1 = item1;
            Item2 = item2;
        }

        public override bool Equals(object obj)
        {
            return obj is NewStruct other &&
                   System.Collections.Generic.EqualityComparer<string[]>.Default.Equals(Item1, other.Item1) &&
                   System.Collections.Generic.EqualityComparer<object>.Default.Equals(Item2, other.Item2);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Item1, Item2);
        }

        public void Deconstruct(out string[] item1, out object item2)
        {
            item1 = Item1;
            item2 = Item2;
        }

        public static implicit operator (string[], object)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((string[], object) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }
}
   
