using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Creating_Classes_TTV
{
    class Album : MediaTypeBase
    {
        public readonly string Artist;

        public Album(string title, string artist) : base (title)
        {
            Artist = artist;
        }

        public string GetDisplayText()
        {
            if (!string.IsNullOrEmpty(Loanee)) return "Album: " + Title + " by " + Artist + (onLoan ? " (Currently on loan to " + Loanee + ")" : "");
            else return "Album: " + Title + " by " + Artist + (onLoan ? " (Currently on loan)" : "");
        }
    }
}
