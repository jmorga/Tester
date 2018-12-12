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
























            Person test = new Person("Cedric", "Miller", "YO MOMS BOYFRIEND", "uncleStepDad69", 12);

            User test1 = new User("Ced", "Mill", "YO MOMS BOYFRIEND", "uncleStepDad69", 12);

            User test2 = new User("Ced", "Mill", "YO MOMS BOYFRIEND", "uncleStepDad69", 12);

            LinkedList<User> list = new LinkedList<User>();

            list.AddFirst(test1);

            list.AddFirst(test2);

            //Console.WriteLine(list.Contains(test1));
            //Console.Read();

            //String test = "You have saved me";


            var saveState = JsonConvert.SerializeObject(list);

            Console.Write(saveState);
            Console.Read();

            String path = "some.txt";

            
            //For loading data
            //LinkedList<User> deserializedProduct = JsonConvert.DeserializeObject<LinkedList<User>>(saveState);

            //Console.Write(deserializedProduct);
            //Console.Read();

            if (File.Exists(path))
            {
                File.Delete(path);
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(saveState);

                    tw.Close();
                }

            }

            else if (!(File.Exists(path)))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(saveState);
                    tw.Close();
                }
            }


            //string fileName = "saveState.dat";

            //var movie =  new Movie("Two Girls One Cup", "Cedric", 30, "Educational", "Very educational", "Now", 10, "8=D");

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