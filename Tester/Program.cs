using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var movie = new Movie("Two Girls One Cup", "Cedric", 30, "Educational", "Very educational", "Now", 10 , "8=D");
            var movie2 = new Movie("Two Girls One Cup", "Cedric", 30, "Educational", "Very educational", "Now", 10, "8=D");

            LinkedList<Movie> list = new LinkedList<Movie>();
            list.AddFirst(movie);

            Console.WriteLine(movie.ToString());
            Console.WriteLine($"\nContains: {list.Contains(new Movie("Two Girls One Cup", "Cedric", 30, "Educational", "Very educational", "Now", 10, "8=D"))}");



            //var user = new User("Joseph", "Morga", "jmorga", "puta", 23);

            //Console.WriteLine(user.ToString());

            //user.setFirstName("Cedric");
            //user.setLastName("Miller");
            //user.setPassword("puto");
            //user.setUsername("Ced");

            //Console.WriteLine($"\n{user.ToString()}");

            //LinkedList<User> list = new LinkedList<User>();

            //list.AddFirst(user);

            //Console.WriteLine($"\nElements: {list.Count}");
            //Console.WriteLine($"Contains jmorga: {list.Contains(new User("","","jmorga","",0))}");
            //Console.WriteLine($"Contains Ced: {list.Contains(new User("", "", "Ced", "", 0))}");
            //Console.WriteLine($"Contains Ced: {list.Contains(new User("Cedric", "Miller", "Ced", "puto", 23))}");

            //var newUser = list.Find(new User("", "", "Ced", "", 0)).Value;

            //Console.WriteLine($"\n{newUser.ToString()}");

            //list.AddFirst(new User("Joseph", "Morga", "jmorga", "puta", 23));

            //Console.WriteLine($"\nElements: {list.Count}");
            //Console.WriteLine($"Contains jmorga: {list.Contains(new User("", "", "jmorga", "", 0))}");
            //Console.WriteLine($"Contains Ced: {list.Contains(new User("", "", "Ced", "", 0))}");

            Console.ReadLine();
        }
    }
}