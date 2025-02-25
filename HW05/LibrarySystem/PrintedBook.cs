// Written by James Jang
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class PrintedBook : Book
    {
        // class variables
        private int pageCount = -1;

        // gets and sets
        public int PageCount
        {
            get { return this.pageCount; }
            set { this.pageCount = value; }
        }

        // constructors
        public PrintedBook(string aTitle, string anAuthor, string aYearPublished, int aPageCount) : base(aTitle, anAuthor, aYearPublished)
        {
            this.PageCount = aPageCount;
        }
        public PrintedBook() : this("unknown", "unknown", "unknown", -1) { }

        // class methods
        public override string ToString()
        {
            return base.ToString() + $", Number of pages: {this.PageCount}";
        }

    }
}
