using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSystem
{
    class sqlConnections
    {

        public Boolean verifyLogin(String username,String password)
        {
            bool loginVerifed = false;
            if(username.Equals("test") && password.Equals("test"))
            {
                loginVerifed = true;
            }

            return loginVerifed;
        }
    }
}
