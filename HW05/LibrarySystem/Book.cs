// Written by James Jang
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Book
    {
        // class variables
        protected string title = "n/a";
        protected string author = "n/a";
        protected string yearPublished = "n/a";

        // gets and sets
        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }
        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }
        public string YearPublished
        {
            get { return this.yearPublished; }
            set { this.yearPublished = value; }
        }

        // constructors
        public Book(string aTitle, string anAuthor, string aYearPublished)
        {
            this.Title = aTitle;
            this.Author = anAuthor;
            this.YearPublished = aYearPublished;
        }
        public Book(): this("unknown", "unknown", "unknown") { }

        // class methods
        public override string ToString()
        {
            return $"{this.Title} by {this.Author} ({this.YearPublished})";
        }
    }
}
