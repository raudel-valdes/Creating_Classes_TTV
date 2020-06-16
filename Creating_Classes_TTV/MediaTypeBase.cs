using System;
using System.Collections.Generic;
using System.Text;

namespace Creating_Classes_TTV
{
    class MediaTypeBase
    {
        public string Title;
        public string Loanee = "";
        public bool onLoan = false;

        public MediaTypeBase(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new System.ArgumentException("A media type must have a title.", "title");
            }

            Title = title;
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
