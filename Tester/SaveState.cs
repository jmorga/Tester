using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Converters;

namespace Tester
{
    public class SaveState
    {

        public void SaveData(object userlist, object adminList)
        {
             
            Data data = new Data((LinkedList<User>)userlist,(LinkedList<Admin>) adminList);

            var saveState = JsonConvert.SerializeObject(data);

            Person deserializedProduct = JsonConvert.DeserializeObject<Person>(saveState);

            String path = "some.txt";

            if (File.Exists(path))
            {
                File.Delete(path);
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(deserializedProduct);

                    tw.Close();
                }

            }

            else if (!(File.Exists(path)))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(deserializedProduct);
                    tw.Close();
                }
            }



        }

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
