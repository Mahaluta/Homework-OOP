using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Book
    {
        // constructors
        public Book(string name, decimal price, string genre) {
            this.Name = name;
            this.Price = price;
            this.Genre = genre;
        }

        // fields
        public string Name { get; set; }
        private decimal Price { get; set; }
        private string Genre { get; set; }
        public Author author = new Author(); // no name, no email
        private bool changeAuthor = false;

        // methods
        public void AddAuthor(Author auth)
        {
            if (!changeAuthor)
                if (author.Name != auth.Name)
                {
                    author.Name = auth.Name;
                    author.Email = auth.Email;
                    changeAuthor = true;
                }
        }

        public decimal GetPrice()
        {
            if (Genre == "Drama")
                return Price - (decimal)0.10 * Price;
            else if (Genre == "SF")
                return Price - (decimal)0.15 * Price;
            else
                return Price;
        }
       
        public void Print()
        {
            Console.WriteLine($"\nThe book's name is: {Name}.");
            Console.WriteLine($"The book's genre is: {Genre}.");
            Console.WriteLine($"The author of the books is: {author.Name}. \n");
        }
    }
}
