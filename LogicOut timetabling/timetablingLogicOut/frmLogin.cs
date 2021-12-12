using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timetablingLogicOut
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            User newU = new User();
            if ( username =="" || password == "")
            {
                MessageBox.Show("Please enter username AND password");
            }
            else if(newU.Login(username, password) == true)
            {
                if(newU.isAdmin(username, password) == true)
                {
                    this.Hide();
                    frmMain newM = new frmMain();
                    newM.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Hide();
                    frmTimetable newT = new frmTimetable();
                    newT.ShowDialog();
                    this.Close();
                }
            }
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show( "Are you sure you want to leave?","LogicOut Timetabling", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }
    }
}
