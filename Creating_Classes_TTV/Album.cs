using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Creating_Classes_TTV
{
    class Album
    {
        public readonly string Title;
        public readonly string Artist;
        public string Loanee = "";
        public bool onLoan = false;

        public Album(string title, string artist)
        {
            Title = title;
            Artist = artist;
        }

        public string GetDisplayText()
        {
            if (!string.IsNullOrEmpty(Loanee)) return "Album: " + Title + " by " + Artist + (onLoan ? " (Currently on loan to " + Loanee + ")" : "");
            else return "Album: " + Title + " by " + Artist + (onLoan ? " (Currently on loan)" : "");
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
