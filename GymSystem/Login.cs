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

        private void button1_Click(object sender, EventArgs e)
        {
            username = usernameEntry.Text;
            password = passwordEntry.Text;
            sqlConnections sc = new sqlConnections();
            bool login = sc.verifyLogin(username, password);

            if(login == false)
            {
                loginErrorMessage.Visible = true;
                Console.WriteLine(username + " " + password);
            }
            else
            {
                Console.WriteLine(username + " " + password+" has logged in");
                Menue menue = new Menue();
                menue.Show();
                this.Hide();
                
            }
            
        }
    }
}
