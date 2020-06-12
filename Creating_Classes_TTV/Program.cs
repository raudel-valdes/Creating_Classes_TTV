using System;

namespace Creating_Classes_TTV
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instantiating the classes
            Movie firstMovie = new Movie("The Godfather", "Raudel Valdes");
 
            //firstMovie.Title = "The Godfather";
            //firstMovie.Director = "Raudel Valdes";
            
            Book firstBook = new Book("Farenheit 451", "Camielle Riebel");

            //firstBook.Title = "Farenheit 451";
            //firstBook.Author = "Camielle Riebel";
            
            Album firstAlbum = new Album("Rocket Man", "Adamary Valdes");

            //firstAlbum.Title = "Rocket Man";
            //firstAlbum.Artist = "Adamary Valdes";

            //Console.WriteLine("Album: " + firstAlbum.Title + " by " + firstAlbum.Artist);
            //Console.WriteLine("Book: " + firstBook.Title + " by " + firstBook.Author);
            //Console.WriteLine("Movie: " + firstMovie.Title + " by " + firstMovie.Director);


            Console.WriteLine(firstAlbum.GetDisplayText());
            Console.WriteLine(firstBook.GetDisplayText());
            Console.WriteLine(firstMovie.GetDisplayText());

            firstBook.Loan("Raul Valdes");
            Console.WriteLine(firstBook.GetDisplayText());

            firstBook.Return();
            Console.WriteLine(firstBook.GetDisplayText());

            firstMovie.Loan();
            Console.WriteLine(firstMovie.GetDisplayText());

            firstMovie.Return();
            Console.WriteLine(firstMovie.GetDisplayText());
        }
    }
}
