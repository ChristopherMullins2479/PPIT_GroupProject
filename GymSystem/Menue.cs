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
    public partial class Menue : Form
    {
        Boolean admin;
        employee e1 = new employee();
        public Menue()
        {
            InitializeComponent();
        }

        private void mainMenue_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();

            //output message
            String username = e1.GetUsername();
            Console.WriteLine(username + " has logged out");
        }

        private void bookDayOffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void shiftsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlConnections sc = new sqlConnections();
            admin = sc.getEmployeeAccess(admin);

            if (admin)
            {
                MessageBox.Show("Admin");
            }
            else
            {
                MessageBox.Show("only Admin can Edit");
            }
        }
    }
}
