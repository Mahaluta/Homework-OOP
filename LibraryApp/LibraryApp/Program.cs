using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library("Junimea");
            
            // books
            Book book1 = new Book("The Prisoner of Azkaban", 38, "SF");
            Book book2 = new Book("The Order of the Phoenix", 37, "SF");
            Book book3 = new Book("The Deathly Hallows", 39, "SF");
            Book book4 = new Book("The Dark Half", 33, "Horror");
            Book book5 = new Book("The Darkside of The Moon", 34, "Horror");

            // authors
            Author a1 = new Author("J.K. Rowling", "JKRowling@gmail.com"); // valide email
            Author a2 = new Author("Stephen King", "SKing"); // invalide email
            Author a3 = new Author(); // no name, no email

            // adding authors to books
            book1.AddAuthor(a1); // J.K. R.
            book2.AddAuthor(a1); // J.K. R.
            book3.AddAuthor(a1); // J.K. R.
            book4.AddAuthor(a2); // S. K.
            book5.AddAuthor(a3);

            // adding and removing books from the library
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5); Console.Write("\n");
            library.AddBook(book1); // testing an already added book 
            library.RemoveBook("The Prisoner of Azkaban"); // testing removing a book that is in the library
            library.RemoveBook("The Half-Blood Prince"); // testing removing a book that it is not in the library

            // Print()
            library.Print();

            // testing the GetPrice() method
            Console.WriteLine($"The book: {book3.Name} costs {book3.GetPrice()} $.");
            Console.WriteLine($"The book: {book4.Name} costs {book4.GetPrice()} $.");

            Console.ReadKey();

        }
    }
}
