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
        private char sex;

        public Person()
        {
            this.firstName = "John";
            this.lastName = "Doe";
            this.username = "";
            this.password = "";
            this.age = 0;
            this.sex = 'M';
        }

        public Person(string firstName, string lastName, string username, string password, int age, char sex)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.username = username;
            this.password = password;
            this.age = age;
            this.sex = sex;
        }

        // ------- Mutator Mathods ------

        public void setFirstName(string firstName) { this.firstName = firstName; }
        public void setLastName(string lastName) { this.lastName = lastName; }
        public void setUsername(string username) { this.username = username; }
        public void setPassword(string password) { this.password = password; }
        public void setAge(int age) { this.age = age; }
        public void setSex(char sex) { this.sex = sex; }

        //------- Accessor Mathods ------

        public string getFirstName() => firstName;
        public string getLastName() => lastName;
        public string getPassword() => password;
        public string getUsername() => username;
        public int getAge() => age;
        public char getSex() => sex;
    }
}
