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
            fileName = "saveState.dat";

            
            
            loadedContent = null; // load the contents here
        }

        public SaveState(string fileName)
        {
            this.fileName = fileName;

            //open file

            loadedContent = null; // load the contents here
        }

        //Retruns true if data saved successfully, false otherwise
        public bool saveData(object user, object admin)
        {
            Data toSave = new Data((LinkedList<User>)user, (LinkedList<Admin>)admin);

            //Save toSave in file

            return true;
        }

        //Returns user list as type object, must typecast back to LinkedList<User>
        public object getUserList()
        {
            return loadedContent.userList;
        }

        //Returns admin list as type object, must typecast back to LinkedList<Admin>
        public object getAdminList()
        {
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
