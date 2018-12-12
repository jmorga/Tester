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
            var name = "saveSate.anus";

            StreamReader read = null;
            try
            {
                read = new StreamReader(name);
            }
            catch(FileNotFoundException e)
            {
            }

            User ced = JsonConvert.DeserializeObject<User>(read.ReadLine());

            read.Close();

            Console.WriteLine(ced);




            Console.ReadLine();
        }
    }
}