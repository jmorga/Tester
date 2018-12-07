using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tester
{
    public class SaveState<T, E>
    {
        public void saveData(LinkedList<T> data1, LinkedList<E> data2)
        {
            //create the json object

            Data<T, E> data = new Data<T, E>(data1, data2);
            String saveState = JsonConvert.SerializeObject(data);

            String path = "C:\Users\Cedric Miller\source\repos\jmorga";

            if (File.Exists(path))
            {
                File.Delete(path);
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(saveState.ToString());
                    tw.Close();
                }

            }

            else if (!(File.Exists(path)))
            {
                using (var tw = new StreamWriter(path, true))
                {
                    tw.WriteLine(saveState.ToString());
                    tw.Close();
                }
            }

           

        }


        public void loadData(LinkedList<T> data1, LinkedList<E> data2)
        {
            //variable = the object in the file
            //var data = //whatever is in the file...

           data1 = data.getData1();
           data2 = data.getData2();
        }

        private class Data<T, E> : SaveState<T,E>
        {
            private LinkedList<T> data1;
            private LinkedList<E> data2;

            public Data(LinkedList<T> data1, LinkedList<E> data2)
            {
                this.data1 = data1;
                this.data2 = data2;
            }

            public LinkedList<T> getData1() => data1;

            public LinkedList<E> getData2() => data2;

        }

    }

}
