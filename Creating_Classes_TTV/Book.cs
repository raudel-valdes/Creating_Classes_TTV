using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_Classes_TTV
{
    class Book
    {
        public readonly string Title;
        public readonly string Author;
        public string Loanee = "";
        public bool onLoan = false;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public string GetDisplayText()
        {
            if (!string.IsNullOrEmpty(Loanee)) return "Book: " + Title + " by " + Author + (onLoan ? " (Currently on loan to " + Loanee + ")" : "");
            else return "Book: " + Title + " by " + Author + (onLoan ? " (Currently on loan)" : "");
        }

        public void Loan(string name)
        {
            Loanee = name;
            Loan();
        }

        public void Loan()
        {
            onLoan = true;
        }

        public void Return()
        {
            Loanee = "";
            onLoan = false;
        }
    }
}
