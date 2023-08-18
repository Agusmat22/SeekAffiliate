using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        TypeUser typeUser;

        public User(string user,string password,TypeUser typeUser) 
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
    }
}
