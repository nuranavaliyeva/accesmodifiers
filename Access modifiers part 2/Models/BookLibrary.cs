using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Access_modifiers_part_2.Models
{
    internal class BookLibrary
    {
        public string _name;
        public Book[] _books;
        public int _count;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Book[] Books
        {
            get { return _books; }
            set
            {
                if (value != null)
                {
                    _books = value;
                }
            }
        }


        public BookLibrary(string name)
        {
            _name = name;
            _books = new Book[0];

        }
        public void Add(Book book)
        {
            Array.Resize(ref _books, _books.Length + 1);
            Books[Books.Length - 1] = book;
            for (int i = 0; i < Books.Length; i++)
            {
                Console.WriteLine($"elave olunanlar: {book.Name}");
                return;
            }


        }



        public void ShowAll()
        {
            Console.WriteLine($"{_name}");
            foreach (var book in _books)
            {
                if (book != null)
                {
                    book.GetInfo();
                }


            }



        }

        public void Remove(Book book)
        {
            int findIndex = Array.IndexOf(_books, book);

            if (findIndex != -1)
            {
                for (int i = findIndex; i < _books.Length - 1; i++)
                {
                    _books[i] = _books[i + 1];
                }

                Array.Resize(ref _books, _books.Length - 1);
                _count--;
                Console.WriteLine($"{book.Name} adinda kitab silindi.");
            }
            else
            {
                Console.WriteLine($"{book.Name} adinda kitab yoxdur!");
            }
        }
        public void BorrowBook(Book name)
        {
            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i] == name)
                {
                    _books[i].isAvailable = false;
                    Console.WriteLine($"Borrowed: {_books[i].Name}");
                    return;

                }
            }

        }
        public void ReturnBook(Book name)
        {
            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i] == name)
                {
                    _books[i].isAvailable = true;
                    Console.WriteLine($"Returned:{_books[i].Name}");
                    return;
                }

            }
        }
       
        //public void SearchByAuthor(Book author)
        //{
            
        //    for (int i = 0; i < _books.Length; i++)
        //    {
        //        if ( _books[i].Author == author)
        //        {
        //            _books[i].GetInfo();


        //        }
        //        else
        //        {
        //            Console.WriteLine("bele bir kitab yoxdu");
        //        }

        //    }

        //}
    }
    }











