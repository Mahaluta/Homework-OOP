using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
   public class Library
    {
        // constructors
        public Library(string name)
        {
            this.Name = name;
        }

        // fields
        private string Name { get; set; }
        List<Book> Books = new List<Book>();
        public bool findBook = false;

        // methods
        public void AddBook(Book bookToAdd)
        {
            bool find = false;
            foreach (Book book in Books)
            {
                
                if (book.Name == bookToAdd.Name)
                {
                    Console.WriteLine($"The library already has the book: {book.Name}.");
                    find = true;
                    break;
                }

            }
            if (find == false)
            {
                Books.Add(bookToAdd);
                Console.WriteLine($"The book: {bookToAdd.Name} has been added to the library.");
            }   
        }
        

        public void RemoveBook(string bookName)
        {
            
            foreach (Book book in Books)
                if (book.Name == bookName)
                {
                    Books.Remove(book);
                    Console.WriteLine($"The book: {book.Name} has been removed from the library.");
                    findBook = true;
                    break;
                }
            if(!findBook)
            Console.WriteLine($"The book: {bookName} couldn't be found in the library.");

        }

        public void Print()
        {
            Console.WriteLine("\nThe library has: -----------------");
            foreach(Book book in Books)
            {
                book.Print();
            }
            Console.WriteLine("----------------------------------");
        }
    }
}
