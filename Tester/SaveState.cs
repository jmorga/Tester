using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Tester
{
    public class SaveState
    {
        private string fileName;
        private Data loadedContent;

        public SaveState()
        {
             //For loading data
            
            fileName = "saveState.dat";
            String savedData = "";
            bool fileFound = true;

            //Open file

            StreamReader readData = null;
            try
            {
                readData = new StreamReader(fileName);
                savedData   = readData.ReadToEnd();
                readData.Close();
            }
            catch (FileNotFoundException e)
            {
                loadedContent = null;
                fileFound = false;
            }

            if(fileFound)
                loadedContent = JsonConvert.DeserializeObject<Data>(savedData); // load the contents here
            
        }

        public SaveState(string fileName)
        {
            this.fileName = fileName;
            String savedData = "";
            bool fileFound = true;

            //Open file

            StreamReader readData = null;
            try
            {
                readData = new StreamReader(fileName);
                savedData = readData.ReadToEnd();
                readData.Close();
            }
            catch (FileNotFoundException e)
            {
                loadedContent = null;
                fileFound = false;
            }

            if (fileFound)
                loadedContent = JsonConvert.DeserializeObject<Data>(savedData); // load the contents here
            
        }

        public void loadData()
        {
            bool fileFound = true;
            String savedData = "";
            //Open file

            StreamReader readData = null;
            try
            {
                readData = new StreamReader(fileName);
                savedData = readData.ReadToEnd();
                readData.Close();
            }
            catch (FileNotFoundException e)
            {
                loadedContent = null;
                fileFound = false;
            }

            if (fileFound)
                loadedContent = JsonConvert.DeserializeObject<Data>(savedData); // load the contents here
        }

        //Retruns true if data saved successfully, false otherwise
        public bool saveData(object user, object admin)
        {
            

            Data toSave = new Data((LinkedList<User>)user, (LinkedList<Admin>)admin);

            //Save toSave in file

            //Console.WriteLine(list.Contains(test1));
            //Console.Read();

            var saveState = JsonConvert.SerializeObject(toSave);


            //For loading data
            //LinkedList<User> deserializedProduct = JsonConvert.DeserializeObject<LinkedList<User>>(saveState);

            //Console.Write(deserializedProduct);
            //Console.Read();

            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                using (var tw = new StreamWriter(fileName, false))
                {
                    tw.WriteLine(saveState);

                    tw.Close();
                }

            }

            else if (!(File.Exists(fileName)))
            {
                using (var tw = new StreamWriter(fileName, false))
                {
                    tw.WriteLine(saveState);
                    tw.Close();
                }
            }

            return true;
        }

        //Returns user list as type object, must typecast back to LinkedList<User>
        public object getUserList()
        {
            if (loadedContent == null) return null;

            return loadedContent.userList;
        }

        //Returns admin list as type object, must typecast back to LinkedList<Admin>
        public object getAdminList()
        {
            if (loadedContent == null) return null;

            return loadedContent.adminList;
        }

        private class Data
        {
            [JsonProperty("masterUserList")]
            public LinkedList<User> userList { get; set; }
            [JsonProperty("masterAdminList")]
            public LinkedList<Admin> adminList { get; set; }

            public Data(LinkedList<User> userList, LinkedList<Admin> adminList)
            {
                this.userList = userList;
                this.adminList = adminList;
            }
        }

    }

}
