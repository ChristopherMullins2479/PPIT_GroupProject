using GYMDATABASE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymSystem
{
    public partial class Login : Form
    {
        String username, password;
        public Login()
        {
            InitializeComponent();
            passwordEntry.PasswordChar = '*';
        }

        //runs when loginButton is pressed
        //will gather text from the two text boxes
        //will create a new Instance of the sqlConnection class
        //will verify if the login is a sucess
        private void button1_Click(object sender, EventArgs e)
        {
            username = usernameEntry.Text;
            password = passwordEntry.Text;

            //sqlConnections sc = new sqlConnections();
            DBAccess dba = new DBAccess();
            DataTable employeeLogin = new DataTable();

            //employee e1 = new employee();
            //e1.SetUsername(username);
            //e1.SetPassword(password);

            //bool login = sc.verifyLogin(username, password);
            //sc.test();

            String logInQuery = "SELECT * from employeeLogin WHERE username ='" + username + "' AND password = '" + password + "'";
            dba.readDatathroughAdapter(logInQuery, employeeLogin);

            if (employeeLogin.Rows.Count == 0)
            {
                //sets the error message to visiable
                //empty the password and user entry boxes
                loginErrorMessage.Visible = true;
                passwordEntry.Text = "";
                usernameEntry.Text = "";
                Console.WriteLine(username + " " + password);
                dba.closeConn();
            }
            else
            {
                Console.WriteLine(username + " " + password+" has logged in");
                Menue menue = new Menue();
                menue.Show();
                this.Hide();
                dba.closeConn();
            }
            
        }
    }
}
