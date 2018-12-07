using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Tester
{
    public class SaveState
    {
        //public void saveData(LinkedList<User> data1, LinkedList<Admin> data2)
        //{
        //    //create the json object

        //    Data data = new Data(data1, data2);
        //    String saveState = JsonConvert.SerializeObject(data);

        //    String path = "C:\Users\Cedric Miller\source\repos\jmorga";

        //    if (File.Exists(path))
        //    {
        //        File.Delete(path);
        //        using (var tw = new StreamWriter(path, true))
        //        {
        //            tw.WriteLine(saveState.ToString());
        //            tw.Close();
        //        }

        //    }

        //    else if (!(File.Exists(path)))
        //    {
        //        using (var tw = new StreamWriter(path, true))
        //        {
        //            tw.WriteLine(saveState.ToString());
        //            tw.Close();
        //        }
        //    }

           

        //}


        //public void loadData(LinkedList<User> data1, LinkedList<Admin> data2)
        //{
        //    //variable = the object in the file
        //    //var data = //whatever is in the file...

        //   data1 = data.getData1();
        //   data2 = data.getData2();
        //}

        //private class Data
        //{
        //    private LinkedList<User> data1;
        //    private LinkedList<Admin> data2;

        //    public Data(LinkedList<User> data1, LinkedList<Admin> data2)
        //    {
        //        this.data1 = data1;
        //        this.data2 = data2;
        //    }

        //    public LinkedList<User> getData1() => data1;

        //    public LinkedList<Admin> getData2() => data2;

        //}

    }

}
