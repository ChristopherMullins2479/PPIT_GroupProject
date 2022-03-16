using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GymSystem
{
    class sqlConnections
    {

        public Boolean verifyLogin(String username,String password)
        {
            String logInQuery = "SELECT * from employeeLogin WHERE username ='" + username +"' AND password = '"+password+"'";
            bool loginVerifed = false;

            //check login details 
            
            return loginVerifed;
        }

        public bool getEmployeeAccess(bool admin)
        {
            return false;
        }
    }
}
