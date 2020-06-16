using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_Classes_TTV
{
    class Book : MediaTypeBase
    {
        public readonly string Author;
 

        public Book(string title, string author) : base(title)
        {
            Author = author;
        }

        public string GetDisplayText()
        {
            if (!string.IsNullOrEmpty(Loanee)) return "Book: " + Title + " by " + Author + (onLoan ? " (Currently on loan to " + Loanee + ")" : "");
            else return "Book: " + Title + " by " + Author + (onLoan ? " (Currently on loan)" : "");
        }
    }
}
