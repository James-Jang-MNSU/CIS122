// Written by James Jang
// 02/24/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class EBook : Book
    {
        // class variables
        private double fileSizeMB = -1;

        // gets and sets
        public double FileSizeMB
        {
            get { return this.fileSizeMB; }
            set { this.fileSizeMB = value; }
        }

        // constructors
        public EBook(string aTitle, string anAuthor, string aYearPublished, double aFileSizeMB): base(aTitle,  anAuthor, aYearPublished)
        {
            this.FileSizeMB = aFileSizeMB;
        }
        public EBook() : this("unknown", "unknown", "unknown", -1) { }

        // class methods
        public override string ToString()
        {
            return base.ToString() + $", File Size: {this.FileSizeMB}MB";
        }

    }
}
