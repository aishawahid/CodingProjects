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
    public partial class frmStudent : Form
    {
        Timetable newT = new Timetable();
        Student newS = new Student();
        SessionChosen newSC = new SessionChosen();
        User newU = new User();

        public frmStudent()
        {
            InitializeComponent();
            populateComboboxes();
        }

        public void populateComboboxes()
        {
            DataTable StudentDT = newT.comboBoxValues("Student", true);
            cbStudentUpdate.DisplayMember = "Name";
            cbStudentUpdate.ValueMember = "ID";
            cbStudentUpdate.DataSource = StudentDT;
            DataTable StudentDT2 = newT.comboBoxValues("Student", true);
            cbStudentDelete.DisplayMember = "Name";
            cbStudentDelete.ValueMember = "ID";
            cbStudentDelete.DataSource = StudentDT2;

        }
        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            
            string name = tbAddStudentName.Text;
            string num = tbAddStudentNum.Text;
            string email = tbAddStudentEmail.Text;
            long phonenum =0;
            bool isValidNumber = false;
            string replacedNum = num.Replace(" ", "");

            if (long.TryParse(replacedNum, out phonenum) == true)
            {
                if(replacedNum.Length == 10 || replacedNum.Length == 11)
                {
                    isValidNumber = true;
                }
                else
                {
                    isValidNumber = false;
                }
                
            }

            if (name == "" || num == "" || email == "")
            {
                MessageBox.Show("Please enter a value in all boxes");
            }
            else if(newT.isNameUnique(name, "Student") == false)
            {
                MessageBox.Show("A student with the same name has already been entered");
            }
            else if(isValidNumber == false)
            {
                MessageBox.Show("Please enter a valid phone number");
            }
            else if (newU.checkCharacter('@', email) == false)
            {
                MessageBox.Show("Please enter a valid email address");
            }
            else
            {
                newS.createStudent(name, num, email);
                populateComboboxes();
                tbAddStudentEmail.ResetText();
                tbAddStudentName.ResetText();
                tbAddStudentNum.ResetText();
            }
        }

        private void btnStudentUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbStudentUpdate.SelectedValue);
            string name = tbUpdateStudentName.Text;
            string num = tbUpdateStudentNum.Text;
            string email = tbUpdateStudentEmail.Text;
            string selectedName = Convert.ToString(cbStudentUpdate.Text);
            long phonenum = 0;
            bool isValidNumber = false;
            string replacedNum = num.Replace(" ", "");

            if (long.TryParse(replacedNum, out phonenum) == true)
            {
                if (replacedNum.Length == 10 || replacedNum.Length == 11)
                {
                    isValidNumber = true;
                }
                else
                {
                    isValidNumber = false;
                }

            }

            if (name == "" || num == "" || email == "" || id == 0)
            {
                MessageBox.Show("Please enter a value in all boxes");
            }
            else if(newT.isNameUnique(name, "Student") == false && selectedName != name)
            {
                MessageBox.Show("Please choose a unique name as this name already exists");
            }
            else if (isValidNumber == false)
            {
                MessageBox.Show("Please enter a valid phone number");
            }
            else if (newU.checkCharacter('@', email) == false)
            {
                MessageBox.Show("Please enter a valid email address");
            }
            else
            {
                newS.updateStudent(id, name, num, email);
                populateComboboxes();
                tbUpdateStudentEmail.ResetText();
                tbUpdateStudentName.ResetText();
                tbUpdateStudentNum.ResetText();
            }
        }

        private void btnStudentDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbStudentDelete.SelectedValue);
            newS.studentDeleteRecord(id);
            populateComboboxes();
        }
        
        private void btnGoToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain newfrmM = new frmMain();
            newfrmM.ShowDialog();
            this.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudentView newSV = new frmStudentView();
            newSV.ShowDialog();
            this.Close();
        }
    }
}
