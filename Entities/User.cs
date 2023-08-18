using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;


using System.Text.Json;
using Newtonsoft.Json;


namespace Entities
{
    public enum TypeUser
    {
        ADMIN,
        COMMON
    }

    public class User
    {
        string user;
        string password;
        string typeUser;

        public User(string user,string password,string typeUser) 
        { 
            this.user = user;
            this.password = password;
            this.typeUser = typeUser;
            
        }

        //This is for validation the password
        public static bool operator ==(User user,string pass)
        {
            return user.password == pass;
        }

        
        
        public static bool operator !=(User user, string pass)
        {
            return user.password != pass;
        }

        public string GetUser
        {
            get { return user; }
        }

        public bool AccessValidation()
        {
            if (typeUser.ToString() == "ADMIN" )
            {
                return true;
            }
            return false;
        }
        /*
        public string ToJson()
        {
            
            return JsonConvert.SerializeObject(new { Name = this.user, Password = this.password }, Formatting.Indented);
        }*/
    }
}
