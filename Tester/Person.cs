using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Person
    {
        private string firstName;
        private string lastName;
        private string username;
        private string password;
        private int age;
        private string access;

        public Person()
        {
            this.firstName = "John";
            this.lastName = "Doe";
            this.username = "";
            this.password = "";
            this.age = 0;
        }

        public Person(string firstName, string lastName, string username, string password, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.password = password;
            this.age = age;
        }

        // ------- Mutator Mathods ------

        public void setFirstName(string firstName) { this.firstName = firstName; }
        public void setLastName(string lastName) { this.lastName = lastName; }
        public void setUsername(string username) { this.username = username; }
        public void setPassword(string password) { this.password = password; }
        public void setAge(int age) { this.age = age; }

        //------- Accessor Mathods ------

        public string getFirstName() => firstName;
        public string getLastName() => lastName;
        public string getPassword() => password;
        public string getUsername() => username;
        public int getAge() => age;


        public override bool Equals(Object obj)
        {
            if (obj == null) return false;

            return this.username.Equals(((User)obj).getUsername());
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Name: {this.getFirstName()} {this.getLastName()}\nUsername: {this.getUsername()}\nPassword: {this.getPassword()}\nAge: {this.getAge()}";
        }
    }
}
