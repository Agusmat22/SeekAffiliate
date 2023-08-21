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
using BCrypt.Net;


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
        string hashPassword;
        string typeUser;

        public User(string user,string hashPassword, string typeUser) 
        { 
            this.user = user.ToUpper();
            this.hashPassword = hashPassword;
            this.typeUser = typeUser;
            
        }

      
        public string GetUser
        {
            get { return user; }
        }
        public string GetHashPassword
        {
            get { return hashPassword; }
        }

        public string GetTypeUser
        {
            get { return typeUser; }
        }

        public string Show()
        {
            return $"Hola mi nombre es {user}";
        }

        public bool AccessValidation()
        {
            if (typeUser.ToString() == "ADMIN" )
            {
                return true;
            }
            return false;
        }

        public bool PassValidation(string passJoin)
        {
            return BCrypt.Net.BCrypt.Verify(passJoin, hashPassword);
        }




    }
}
