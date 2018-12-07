using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    public class SaveState
    {
        

        private class Data
        {
            private LinkedList<User> data1;
            private LinkedList<Admin> data2;

            public Data(LinkedList<User> data1, LinkedList<Admin> data2)
            {
                this.data1 = data1;
                this.data2 = data2;
            }

            public Data()
            {
                this.data1 = null;
                this.data2 = null;
            }

            public LinkedList<User> getData1() => data1;

            public LinkedList<Admin> getData2() => data2;

        }

    }

}
