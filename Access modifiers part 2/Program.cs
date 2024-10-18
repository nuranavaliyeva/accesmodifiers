using Access_modifiers_part_2.Models;

namespace Access_modifiers_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            BookLibrary library = new BookLibrary("My Library");

            Book book1 = new ("Sirli Bag", "Frensis Bernet", false);
            Book book2 = new("salam", "Nurane");
   
            library.Add(book1);
            library.Add(book2);
            library.BorrowBook(book2);
           library.ReturnBook(book2);
            Console.WriteLine("----------------------");
            


            book1.GetInfo();  
            book2.GetInfo();
           






        }
    }
}
