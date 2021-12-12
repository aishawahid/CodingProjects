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
    public partial class frmCourse : Form
    {
        Timetable newT = new Timetable();
        Course newC = new Course();

        public frmCourse()
        {
            InitializeComponent();
            populateComboboxes();
        }

        private void populateComboboxes()
        {
            DataTable courseDT = newT.comboBoxValues("Course", true);
            cbCourseUpdate.DisplayMember = "Name";
            cbCourseUpdate.ValueMember = "ID";
            cbCourseUpdate.DataSource = courseDT;
            DataTable courseDT2 = newT.comboBoxValues("Course", true);
            cbCourseDelete.DisplayMember = "Name";
            cbCourseDelete.ValueMember = "ID";
            cbCourseDelete.DataSource = courseDT2;
        }

        private void btnGoToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain newfrmM = new frmMain();
            newfrmM.ShowDialog();
            this.Close();
        }

        private void btnCourseAdd_Click(object sender, EventArgs e)
        {
            string name = tbAddCouseName.Text;
            if(newT.isNameUnique(name, "Course") == false)
            {
                MessageBox.Show("This Course is already stored.");
            }
            else
            {
                newC.createCourse(name);
                populateComboboxes();
                tbAddCouseName.ResetText();
            }
        }

        private void btnCourseUpdate_Click(object sender, EventArgs e)
        {
            string name = tbUpdateCourseName.Text;
            int id = Convert.ToInt32(cbCourseUpdate.SelectedValue);
            string currentName = Convert.ToString(cbCourseUpdate.Text);

            if(name == "" || id == 0)
            {
                MessageBox.Show("Please enter values for all boxes");
            }
            if (newT.isNameUnique(name, "Course") == false && currentName != name)
            {
                MessageBox.Show("This Course is already stored");
            }
            else
            {
                newC.updateCourse(id, name);
                populateComboboxes();
                tbUpdateCourseName.ResetText();
            }
        }

        private void btnCourseDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbCourseDelete.SelectedValue);
            if (id == 0)
            {
                MessageBox.Show("Please select a value");
            }
            else
            {
                DialogResult result = MessageBox.Show( "Are you sure you want to delete all records that reference this course", 
                    "LogicOut Timetabling", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    newC.courseDeleteRecord(id);
                    populateComboboxes();
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCourseView frmCourseView = new frmCourseView();
            frmCourseView.ShowDialog();
            this.Close();
        }
    }
}
