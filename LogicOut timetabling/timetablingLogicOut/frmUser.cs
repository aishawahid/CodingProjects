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
    public partial class frmUser : Form
    {
        User newU = new User();
        Timetable newT = new Timetable();
        public frmUser()
        {
            InitializeComponent();
            populateCombobox();
        }
        private void populateCombobox()
        {
            DataTable userDT = newT.comboBoxValues("Staff", false);
            DataRow newRow = userDT.NewRow();
            cbUserUpdate.DisplayMember = "Name";
            cbUserUpdate.ValueMember = "Username";
            cbUserUpdate.DataSource = userDT;
            DataTable userDT2 = newT.comboBoxValues("Staff", false);
            cbUserDelete.DisplayMember = "Name";
            cbUserDelete.ValueMember = "Username";
            cbUserDelete.DataSource = userDT2;
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            string username = tbAddUserUN.Text;
            string password = tbAddUserPW.Text;
            string name = tbAddUserFN.Text;
            string isAdmin = Convert.ToString(cbAddIsAdmin.SelectedItem);
            int bit = 0;

            if(username == "" || password == "" || name == "" || isAdmin == "")
            {
                MessageBox.Show("Please enter a value in all boxes");
            }
            else if(newU.isUsernameUnique(username) == false)
            {
                MessageBox.Show("This username is already taken");
            }
            else if(username.Length < 7 || newU.checkCharacter(' ', username) == true || username.Length > 30)
            {
                MessageBox.Show("The username needs to be at least 7 characters long, cannot be more than 30 characters and cannot have spaces");
            }
            else if(password.Length < 7 || newU.checkCharacter(' ', password) == true || password.Length > 30)
            {
                MessageBox.Show("The password must be at least 7 charcaters long, cannot be more than 30 characters and cannot have spaces");
            }
            else if (name.Length > 20)
            {
                MessageBox.Show("The student name cannot be more than 20 characters");
            }
            else
            {
                if(isAdmin == "Yes")
                {
                    bit = 1;
                }
                newU.createUser(username, password, name, bit);
                populateCombobox();
                tbAddUserFN.ResetText();
                tbAddUserPW.ResetText();
                tbAddUserUN.ResetText();
                cbAddIsAdmin.ResetText();
            }
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            string username = tbUpdateUserUN.Text;
            string password = tbUpdateUserPW.Text;
            string name = tbUpdateUserFN.Text;
            string isAdmin = Convert.ToString(cbUpdateIsAdmin.SelectedItem);
            string currentUsername = Convert.ToString(cbUserUpdate.SelectedValue);
            
            int bit = 0;

            if (username == "" || password == "" || name == "" || isAdmin == "" || currentUsername == "")
            {
                MessageBox.Show("Please enter a value in all boxes");
            }
            else if (newU.isUsernameUnique(username) == false && username != currentUsername)
            {
                MessageBox.Show("This username is already taken");
            }
            else if (username.Length < 7 || newU.checkCharacter(' ', username) == true)
            {
                MessageBox.Show("The username needs to be at least 7 characters long and cannot have spaces");
            }
            else if (password.Length < 7 || newU.checkCharacter(' ', password) == true)
            {
                MessageBox.Show("The password must be at least 7 charcaters long and cannot have spaces");
            }
            else
            {
                if (isAdmin == "Yes")
                {
                    bit = 1;
                }
                newU.updateUser(username, password, name, bit);
                populateCombobox();
                cbUserUpdate.ResetText();
                cbUpdateIsAdmin.ResetText();
                tbUpdateUserFN.ResetText();
                tbUpdateUserPW.ResetText();
                tbUpdateUserUN.ResetText();
            }

        }

        private void btnUserDelete_Click(object sender, EventArgs e)
        {
            string usernameSelected = Convert.ToString(cbUserDelete.SelectedValue);
            if(usernameSelected == "")
            {
                MessageBox.Show("Please select a record to delete");
            }
            else
            {
                newU.deleteUser(usernameSelected);
                populateCombobox();
            }
        }

        private void btnGoToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain newM = new frmMain();
            newM.ShowDialog();
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserView newUV = new frmUserView();
            newUV.ShowDialog();
            this.Close();
        }
    }
}
