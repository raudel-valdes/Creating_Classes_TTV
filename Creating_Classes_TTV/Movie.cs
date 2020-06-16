using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_Classes_TTV
{
    class Movie : MediaTypeBase
    {
        public readonly string Director;

        public Movie(string title, string director) : base(title)
        {
            Director = director;
        }

        public string GetDisplayText()
        {
            if (!string.IsNullOrEmpty(Loanee)) return "Movie: " + Title + " by " + Director + (onLoan ? " (Currently on loan to " + Loanee + ")" : "");
            else return "Movie: " + Title + " by " + Director + (onLoan ? " (Currently on loan)" : "");
        }

    }
}
