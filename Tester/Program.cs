using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization.Formatters.Binary;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<User> user = new LinkedList<User>();
            LinkedList<Admin> admin = new LinkedList<Admin>();
            string fileName = "saveSate.anus";


            var ced = new User("Cedric", "Miller", "Ceddy", "yo mom's boyfriend", 24);

            Console.WriteLine();

            var toSave = JsonConvert.SerializeObject("json");

            StreamWriter write = new StreamWriter(fileName, false);
            write.WriteLine(toSave);
            write.Close();

            StreamReader read = new StreamReader(fileName);

            var loadedUser = JsonConvert.DeserializeObject<string>(read.ReadLine());
            read.Close();


            Console.WriteLine(loadedUser);
            

            ////--------------Saving Data :3

            //Stream stream = File.Open(fileName, FileMode.Create);

            //BinaryFormatter format = new BinaryFormatter();

            //format.Serialize(stream, movie);

            //stream.Close();

            ////--------------getting data

            //Stream stream2 = File.Open(fileName, FileMode.Open);
            //BinaryFormatter format2 = new BinaryFormatter();

            //var loadedContent = (Movie)format2.Deserialize(stream2);

            //stream2.Close();

            //Console.WriteLine(loadedContent);

            //StreamWriter write = new StreamWriter(fileName, false);
            //write.WriteLine(toSave);
            //write.Close();

            //StreamReader read = new StreamReader(fileName);

            //Movie loadedMovie = JsonConvert.DeserializeObject<Movie>(read.ReadLine());

            //read.Close();

            //Console.WriteLine(loadedMovie);



            //var movie = new Movie("Two Girls One Cup", "Cedric", 30, "Educational", "Very educational", "Now", 10 , "8=D");
            //var movie2 = new Movie("Two Girls One Cup", "Cedric", 30, "Educational", "Very educational", "Now", 10, "8=D");

            //LinkedList<Movie> list = new LinkedList<Movie>();
            //list.AddFirst(movie);

            //Console.WriteLine(movie.ToString());
            //Console.WriteLine($"\nContains: {list.Contains(new Movie("Two Girls One Cup", "Cedric", 30, "Educational", "Very educational", "Now", 10, "8=D"))}");



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