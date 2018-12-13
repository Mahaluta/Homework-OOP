using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    public class Author
    {
        // constructors
        public Author(string name, string Email)
        {
            this.Name = name;
            if(Email.Contains("@yahoo.com") || Email.Contains("@gmail.com"))
                this.Email = Email;
            else
                this.Email = "The email isn't specified.";
        }

        public Author()
        {
            this.Name = "Couldn't find the author's name.";
            this.Email = "The email isn't specified";
        }

        // fields
        public string Name { get; set; }
        public string Email { get; set; }

    }
}
