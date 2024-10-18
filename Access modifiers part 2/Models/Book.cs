using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Access_modifiers_part_2.Models
{
    internal class Book
    {
        public string _name;
        public string _author;
        public bool _isAvailable;
       
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }
       
        public bool isAvailable
        {
            get { return _isAvailable; }
            set { _isAvailable = value; }
        }
        public Book(string _name, string _author, bool _isAvailable=true)
        {
            Name = _name;
           Author=_author;
            isAvailable = _isAvailable;

        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {_name} Author: {_author} Is available: {_isAvailable}");
        }
       
    }
}
