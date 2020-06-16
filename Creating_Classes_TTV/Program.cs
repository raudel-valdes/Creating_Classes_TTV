using System;

namespace Creating_Classes_TTV
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var MediaLibrary = new MediaLibrary(new MediaTypeBase[]
                {
                    new Movie("The Godfather", "Raudel Valdes"),
                    new Book("Farenheit 451", "Camielle Riebel"),
                    new Album("Rocket Man", "Adamary Valdes")
                });

                //Instantiating the classes
                //Movie firstMovie = new Movie("The Godfather", "Raudel Valdes");

                //firstMovie.Title = "The Godfather";
                //firstMovie.Director = "Raudel Valdes";

                //Book firstBook = new Book("Farenheit 451", "Camielle Riebel");

                //firstBook.Title = "Farenheit 451";
                //firstBook.Author = "Camielle Riebel";

                //Album firstAlbum = new Album("Rocket Man", "Adamary Valdes");

                //firstAlbum.Title = "Rocket Man";
                //firstAlbum.Artist = "Adamary Valdes";

                //SUPPOSED TO THROW AN EXCEPTION
                //Album SecondMovie = new Album("", "");

                //Console.WriteLine("Album: " + firstAlbum.Title + " by " + firstAlbum.Artist);
                //Console.WriteLine("Book: " + firstBook.Title + " by " + firstBook.Author);
                //Console.WriteLine("Movie: " + firstMovie.Title + " by " + firstMovie.Director);


                DetectMediaType(MediaLibrary.GetItemAt(0));
                DetectMediaType(MediaLibrary.GetItemAt(1));
                DetectMediaType(MediaLibrary.GetItemAt(2));


                Display(MediaLibrary.GetItemAt(0));
                Display(MediaLibrary.GetItemAt(1));
                Display(MediaLibrary.GetItemAt(5));

                /*
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
                */

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

        }

        public static void Display(MediaTypeBase item)
        {

            if(item == null)
            {
                return;
            }

            if (item is Movie)
            {
                Console.WriteLine(((Movie)item).GetDisplayText());
            }
             else if (item is Book)
            {
                Console.WriteLine(((Book)item).GetDisplayText());
            }
            else if (item is Album)
            {
                Console.WriteLine(((Album)item).GetDisplayText());
            }
            else
            {
                throw new System.ArgumentException("Unexpected media subtype encountered.", "type");
            }
        }

        public static void DetectMediaType(MediaTypeBase item)
        {
            string type = "";

            if (item == null)
            {
                return;
            }

            if (item is Movie) type = "Movie";
            if (item is Book) type = "Book";
            if (item is Album) type = "Album";

            if (type == "")
            {
                throw new System.ArgumentException("Unexpected media subtype encountered.", "type");
            }

           Console.WriteLine(item.Title + " is " + type);
        }
    }
}
