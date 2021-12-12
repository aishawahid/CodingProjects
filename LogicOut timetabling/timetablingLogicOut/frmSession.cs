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
    public partial class frmSession : Form
    {
        Timetable newT = new Timetable();
        Session newS = new Session();
        Schedule newSchedule = new Schedule();
        SessionChosen newSC = new SessionChosen();
        public frmSession()
        {
            InitializeComponent();
            populateComboboxes();
        }

        private void populateComboboxes()
        {
            DataTable courseDT = newT.comboBoxValues("Course", true);
            cbAddSessionCourse.DisplayMember = "Name";
            cbAddSessionCourse.ValueMember = "ID";
            cbAddSessionCourse.DataSource = courseDT;
            DataTable courseDT2 = newT.comboBoxValues("Course", true);
            cbUpdateSessionCourse.DisplayMember = "Name";
            cbUpdateSessionCourse.ValueMember = "ID";
            cbUpdateSessionCourse.DataSource = courseDT2;

            DataTable scheduleDT = newSchedule.CombineName(true);
            cbAddSessionSchedule.DisplayMember = "Name";
            cbAddSessionSchedule.ValueMember = "ID";
            cbAddSessionSchedule.DataSource = scheduleDT;
            DataTable scheduleDT2 = newSchedule.CombineName(true);
            cbUpdateSessionSchedule.DisplayMember = "Name";
            cbUpdateSessionSchedule.ValueMember = "ID";
            cbUpdateSessionSchedule.DataSource = scheduleDT2;

            DataTable roomDT = newT.comboBoxValues("Room", true);
            cbSessionRoom.DisplayMember = "Name";
            cbSessionRoom.ValueMember = "ID";
            cbSessionRoom.DataSource = roomDT;
            DataTable roomDT2 = newT.comboBoxValues("Room", true);
            cbUpdateSessionRoom.DisplayMember = "Name";
            cbUpdateSessionRoom.ValueMember = "ID";
            cbUpdateSessionRoom.DataSource = roomDT2;

            DataTable sessionDT = newS.CombineName(true);
            cbSessionUpdate.DisplayMember = "Name";
            cbSessionUpdate.ValueMember = "ID";
            cbSessionUpdate.DataSource = sessionDT;
            DataTable sessionDT2 = newS.CombineName(true);
            cbSessionDelete.DisplayMember = "Name";
            cbSessionDelete.ValueMember = "ID";
            cbSessionDelete.DataSource = sessionDT2;
            
        }

        private void btnSessionAdd_Click(object sender, EventArgs e)
        {
            int courseID = Convert.ToInt32(cbAddSessionCourse.SelectedValue);
            int scheduleID = Convert.ToInt32(cbAddSessionSchedule.SelectedValue);
            int roomID = Convert.ToInt32(cbSessionRoom.SelectedValue);

            if(courseID == 0 || scheduleID == 0 || roomID == 0)
            {
                MessageBox.Show("Please select a value for all boxes");
            }
            else if (newS.isSessionUnique(courseID, scheduleID, roomID) == false)
            {
                MessageBox.Show("This session has already been added");
            }
            else
            {
                newS.createSession(courseID, scheduleID, roomID);
                populateComboboxes();
            }
        }

        private void btnSessionUpdate_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(cbSessionUpdate.SelectedValue);
            int courseID = Convert.ToInt32(cbUpdateSessionCourse.SelectedValue);
            int scheduleID = Convert.ToInt32(cbUpdateSessionSchedule.SelectedValue);
            int roomID = Convert.ToInt32(cbUpdateSessionRoom.SelectedValue);

            if(courseID == 0 || scheduleID == 0 || roomID == 0 || ID == 0)
            {
                MessageBox.Show("Please select a value for all boxes");
            }
            else if (newS.isSessionUnique(courseID, scheduleID, roomID) == false)
            {
                MessageBox.Show("This session has already been added");
            }
            else
            {
                newS.updateSession(ID, courseID, scheduleID, roomID);
                populateComboboxes();
            }

        }

        private void btnSessionDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbSessionDelete.SelectedValue);
            newS.sessionDeleteRecord(id);
            populateComboboxes();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSessionView newSV = new frmSessionView();
            newSV.ShowDialog();
            this.Close();
        }

        private void btnGoToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain newfrmM = new frmMain();
            newfrmM.ShowDialog();
            this.Close();
        }
    }
}
