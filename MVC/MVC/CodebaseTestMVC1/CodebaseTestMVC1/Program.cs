using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodebaseTestMVC1.model;
namespace CodebaseTestMVC1
{
    class Program
    {
        static MovieDbContext moviedb = new MovieDbContext();
        public static void create()
        {
            var Movie = new Movie
            {
                Mid = 1,
                Moviename = "Don",
                DateofRelease = DateTime.Parse("2000-01-05")
            };
            moviedb.Movies.Add(Movie);
            moviedb.SaveChanges();
            Movie=new Movie
            {
                Mid = 2,
                Moviename = "Jersey",
                DateofRelease = DateTime.Parse("2000-11-05")
            };
            moviedb.Movies.Add(Movie);
            moviedb.SaveChanges();
            Movie = new Movie
            {
                Mid = 3,
                Moviename = "3Idiots",
                DateofRelease = DateTime.Parse("2011-09-13")
            };
            moviedb.Movies.Add(Movie);
            moviedb.SaveChanges();
            var m = from mov in moviedb.Movies
                          select mov;
            Console.WriteLine("List after Creation");
            foreach (var i in m)
            {
                Console.WriteLine(i.Mid + "        " + i.Moviename + "         " + i.DateofRelease);
            }
            Console.WriteLine("-----------------------------------------------------------------");
        }
        public static void Edit()
        {
            var mov1 = from mov in moviedb.Movies
                       select mov;
            Console.WriteLine("please enter the movie name to edit the date of release");
            var name1 = Console.ReadLine();
            var Nmovie = moviedb.Movies.FirstOrDefault(m => m.Moviename == name1);
            Nmovie.DateofRelease = DateTime.Parse("2000-11-05");
            moviedb.SaveChanges();
            var UpdateM = from mov in moviedb.Movies
                       select mov;
            Console.WriteLine("List after Edition");
            foreach (var i in UpdateM)
            {
                Console.WriteLine(i.Mid + "        " + i.Moviename + "         " + i.DateofRelease);
            }
            Console.WriteLine("-----------------------------------------------------------------------");

        }
        public static void Delete(Movie name2)
        {
            var Nmovie = moviedb.Movies.FirstOrDefault(m => m.Moviename == name2.Moviename);
            moviedb.Movies.Remove(name2);
            moviedb.SaveChanges();
            var UpdateM = from mov in moviedb.Movies
                          select mov;
            Console.WriteLine("list after Deletion");
            foreach (var i in UpdateM)
            {
                Console.WriteLine(i.Mid + "        " + i.Moviename + "         " + i.DateofRelease);
            }
            Console.WriteLine("---------------------------------------------------------------------------");

        }
        public static void Display()
        {
            var list1 = moviedb.Movies.ToList();
            var mov1 = from mov in moviedb.Movies
                       select mov;
            var mov2 = list1.FindAll(x => x.DateofRelease > DateTime.Parse("2000-01-01") & x.DateofRelease < DateTime.Parse("2000-12-30"));

            Console.WriteLine("movies released in the year 2000");
            foreach (var i in mov2)
            {
                Console.WriteLine(i.Mid + "        " + i.Moviename + "         " + i.DateofRelease);
            }
            Console.WriteLine("----------------------------------------------------------------------------------");
        }
        public static void Options()
        {

            Console.WriteLine("please choose any of the Crud Operations \n");
            Console.WriteLine("1.Creat \n 2.Edit \n 3.Delete \n 4.to Display the movies released in  year 2000 \n 5.Exit");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    create();
                    Options();
                    break;
                case 2:
                    Edit();
                    Options();
                    break;
                case 3:
                    var Movie = new Movie
                    {
                        Mid = 2,
                        Moviename = "Jersey",
                        DateofRelease = DateTime.Parse("2000-11-05")
                    };
                    Delete(Movie);
                    Options();
                    break;
                case 4:
                    Display();
                    Options();
                    break;
                case 5:
                    break;

            }
        }
        static void Main(string[] args)
        {
            Options();
        }
    }
}
