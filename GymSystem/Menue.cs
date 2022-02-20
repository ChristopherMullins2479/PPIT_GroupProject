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
        }

        private void bookDayOffToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
