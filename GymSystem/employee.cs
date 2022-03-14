using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSystem
{
    class employee
    {
        int employeeID;
        String fname;
        String Surname;
        String _username;
        String _password;

        //username
        public String GetUsername()
        {
            return _username;
        }

        public void SetUsername(String username)
        {
            _username = username;
        }

        //password
        public String GetPassword()
        {
            return _username;
        }

        public void SetPassword(String username)
        {
            _username = username;
        }
    }

   

}
