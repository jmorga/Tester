using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization.Formatters.Binary;

namespace Tester
{
    public class SaveState
    {
        private string fileName = "fileState.anus";
        private Data loadedContent;

        public SaveState()
        {
            try
            {
                Stream stream = File.Open(fileName, FileMode.Open);
                BinaryFormatter format = new BinaryFormatter();

                var loadedContent = (Data)format.Deserialize(stream);

                stream.Close();
            }
            catch (FileNotFoundException e) { }
        }

        public void saveData(object user, object admin)
        {
            Stream stream = File.Open(fileName, FileMode.Create);
            BinaryFormatter format = new BinaryFormatter();

            format.Serialize(stream, new Data((LinkedList<User>)user, (LinkedList<Admin>)admin));

            stream.Close();
        }

        public void loadData(object user, object admin)
        {
            user = this.loadedContent.getData1();
            admin = this.loadedContent.getData2();
        }

        [Serializable()]
        private class Data : ISerializable
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

            public Data(SerializationInfo info, StreamingContext ctxt)
            { 
                this.data1 = (LinkedList<User>)info.GetValue("data1", typeof(LinkedList<User>));
                this.data2 = (LinkedList<Admin>)info.GetValue("data2", typeof(LinkedList<Admin>));
            }

            public LinkedList<User> getData1() => data1;

            public LinkedList<Admin> getData2() => data2;

            public void GetObjectData(SerializationInfo info, StreamingContext context)
            {
                info.AddValue("data1", this.data1);
                info.AddValue("data2", this.data2);
            }
        }

    }

}
