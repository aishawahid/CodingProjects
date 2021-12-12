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
    public partial class frmSessionChosen : Form
    {
        Timetable newT = new Timetable();
        SessionChosen newSC = new SessionChosen();
        Session newS = new Session();

        public frmSessionChosen()
        {
            InitializeComponent();
            populateComboboxes();
        }

        private void populateComboboxes()
        {
            DataTable studentDT = newT.comboBoxValues("Student" , true);
            cbAddChoiceStudent.DisplayMember = "Name";
            cbAddChoiceStudent.ValueMember = "ID";
            cbAddChoiceStudent.DataSource = studentDT;

            DataTable sessionDT = newS.CombineName(true);
            cbAddChoiceSession.DisplayMember = "Name";
            cbAddChoiceSession.ValueMember = "ID";
            cbAddChoiceSession.DataSource = sessionDT;

            DataTable scDT = newSC.CombineName(true, "SessionChosen");
            cbDeleteChoice.DisplayMember = "Choice";
            cbDeleteChoice.ValueMember = "ID";
            cbDeleteChoice.DataSource = scDT;

            DataTable aDT = newSC.CombineName(true, "SessionAllocated");
            cbDeleteAllocated.DisplayMember = "Choice";
            cbDeleteAllocated.ValueMember = "ID";
            cbDeleteAllocated.DataSource = aDT;
        }

        private void btnCourseAdd_Click(object sender, EventArgs e)
        {
            int studentID = Convert.ToInt32(cbAddChoiceStudent.SelectedValue);
            int sessionID = Convert.ToInt32(cbAddChoiceSession.SelectedValue);

            if(studentID == 0 || sessionID == 0)
            {
                MessageBox.Show("Please select a value for all boxes");
            }
            else if (newSC.isSessionChosenUnique(sessionID,studentID) == false)
            {
                MessageBox.Show("This choice is already stored");
            }
            else
            {
                newSC.createSessionChosen(studentID, sessionID);
                populateComboboxes();
            }
        }

        private void btnCourseDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbDeleteChoice.SelectedValue);
            if(id == 0)
            {
                MessageBox.Show("Please select a choice");
            }
            else
            {
                newSC.sessionDeleteRecord(id, "ID", "SessionChosen");
                populateComboboxes();
            }
            
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSessionChosenView newSC = new frmSessionChosenView();
            newSC.ShowDialog();
            this.Close();
        }

        private void btnGoToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain newfrmM = new frmMain();
            newfrmM.ShowDialog();
            this.Close();
        }

        private void btnChoiceAdelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbDeleteAllocated.SelectedValue);
            if (id == 0)
            {
                MessageBox.Show("Please select a choice");
            }
            else
            {
                newSC.sessionDeleteRecord(id, "ID", "SessionAllocated");
                populateComboboxes();
            }
        }
        
    }
}
