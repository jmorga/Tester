using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace Tester
{
    
    class Admin : Person, IComparable<Admin>
    {
        [JsonProperty("list")]
        public LinkedList<User> userList { get; set; }

        public Admin() : base()
        {
            userList = new LinkedList<User>();
        }

        public Admin(string firstName, string lastName, string username, string password, int age)
            : base(firstName, lastName, username, password, age)
        {
            userList = new LinkedList<User>();
        }

        public int CompareTo(Admin obj)
        {
            if (obj == null)
                return 1;

            return this.username.CompareTo(obj.username);
        }

        public void setList(LinkedList<User> list) { this.userList = list; }

        public bool banUser(User user)
        {
            if (!userList.Contains(user))
                return false;

            user.setBan(true);
            return true;
        }

        public bool deleteUser(User user) => userList.Remove(user);

        public User[] getUserList() { return userList.ToArray<User>(); }

        public User searchUser(User user)
        {
            if (!userList.Contains(user))
                return null;

           return userList.Find(user).Value;
        }
    }
}
