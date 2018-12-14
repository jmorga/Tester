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
            FileStream stream = null;
            try
            {
                stream = new FileStream(fileName, FileMode.Open);
                readData = new StreamReader(stream);
                savedData   = readData.ReadToEnd();
                readData.Dispose();
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
            FileStream stream = null;
            try
            {
                stream = new FileStream(fileName, FileMode.Open);
                readData = new StreamReader(stream);
                savedData = readData.ReadToEnd();
                readData.Dispose();
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
            FileStream stream = null;
            try
            {
                stream = new FileStream(fileName, FileMode.Open);
                readData = new StreamReader(stream);
                savedData = readData.ReadToEnd();
                readData.Dispose();
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

            var saveState = JsonConvert.SerializeObject(toSave, Formatting.None, new JsonSerializerSettings()
                                                       { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });



            if (File.Exists(fileName))
            {

                File.Delete(fileName);
                FileStream stream = new FileStream(fileName, FileMode.CreateNew);
                using (var tw = new StreamWriter(stream))
                {
                    tw.WriteLine(saveState);

                    tw.Dispose();
                }

            }

            else if (!(File.Exists(fileName)))
            {
                FileStream stream = new FileStream(fileName, FileMode.CreateNew);
                using (var tw = new StreamWriter(stream))
                {
                    tw.WriteLine(saveState);
                    tw.Dispose();
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
