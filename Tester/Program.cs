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
            SaveState save = new SaveState();

            LinkedList<User> userList = new LinkedList<User>();
            LinkedList<Admin> adminList = new LinkedList<Admin>();

            User tmp1;
            Admin tmp2;

            int max = 10;
            //Creating users and adding movie objects

            for (int i = 0; i < max; i++)
            {
                tmp1 = new User($"{i}", $"{i}", $"{i}", $"{i}", i);
                for (int j = 0; j < max / 2; j++)
                    tmp1.addMovie(new Movie($"{j}", $"{j}", i + j, $"{j}", $"{j}", $"{j}", 1.0, $"{j}"));

                userList.AddFirst(tmp1);
            }

            // Creating admin objcts

            for (int i = 0; i < max / 10; i++)
            {
                tmp2 = new Admin($"{i}", $"{i}", $"{i}", $"{i}", i);

                tmp2.setList(userList);

                adminList.AddFirst(tmp2);
            }

            // Saving list in file

            save.saveData(userList, adminList);

            //loading contents

            save.loadData();

            //LinkedList<User> loadedUser = (LinkedList<User>)save.getUserList();
            //LinkedList<Admin> loadedAdmin = (LinkedList<Admin>)save.getAdminList();

            //User[] x = loadedUser.ToArray<User>();

            //for (int i = 0; i < max; i++)
            //{
            //    Console.WriteLine(loadedUser.Contains(new User($"{9 - i}", $"{9 - i}", $"{9 - i}", $"{9 - i}",9-i)));
            //}
            

            Console.ReadLine();
        }
    }
}