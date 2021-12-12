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
    public partial class frmSchedule : Form
    {
        Timetable newT = new Timetable();
        Schedule newS = new Schedule();
        Session newSession = new Session();
        SessionChosen newSC = new SessionChosen();
        MakingTimetable newMt = new MakingTimetable();

        public frmSchedule()
        {
            InitializeComponent();
            populateComboBoxes();
        }

        private void populateComboBoxes()
        {
            DataTable ScheduleTable = newS.CombineName(true);
            cbUpdateScheduleday.DisplayMember = "Name";
            cbUpdateScheduleday.ValueMember = "ID";
            cbUpdateScheduleday.DataSource = ScheduleTable;
            DataTable ScheduleTable2 = newS.CombineName(true);
            cbDeleteSchedDay.DisplayMember = "Name";
            cbDeleteSchedDay.ValueMember = "ID";
            cbDeleteSchedDay.DataSource = ScheduleTable2;
        }

        private void btnGoToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain newfrmM = new frmMain();
            newfrmM.ShowDialog();
            this.Close();
        }

        private void btnSchedulesAdd_Click(object sender, EventArgs e)
        {
            string day = Convert.ToString(cbAddDay.SelectedItem);
            string starttime = Convert.ToString(tbAddScheduleST.Text);
            string endtime = Convert.ToString(tbAddScheduleET.Text);
            int starttimei = Convert.ToInt32(starttime.Replace(":", string.Empty));
            int endtimei = Convert.ToInt32(endtime.Replace(":", string.Empty));
            if (day == "" || starttime == "" || endtime == "" )
            {
                MessageBox.Show("Please enter a value in all boxes");
            }
            else if (starttime.Length != 5 || endtime.Length != 5)
            {
                MessageBox.Show("Please enter times in 24hr format");
            }
            else if (starttimei >= endtimei)
            {
                MessageBox.Show("End Time has to be after Start Time");
            }
            else if (newS.isScheduleUnique(day,starttime,endtime) == false)
            {
                MessageBox.Show("This schedule is already stored");
            }
            else
            {
                newS.createSchedule(day, starttime, endtime);
                populateComboBoxes();
                tbAddScheduleET.ResetText();
                tbAddScheduleST.ResetText();
            }
            
        }

        private void btnScheduleUpdate_Click(object sender, EventArgs e)
        {
            string starttime = tbUpdateScheduleST.Text;
            string endtime = tbUpdateScheduleET.Text;
            string day = Convert.ToString(cbUpdateDay.Text);
            int id = Convert.ToInt32(cbUpdateScheduleday.SelectedValue);int starttimei = Convert.ToInt32(starttime.Replace(":", string.Empty));
            int endtimei = Convert.ToInt32(endtime.Replace(":", string.Empty));

            if ( day == "" || starttime == "" || endtime == "" || Convert.ToString(id) == "")
            {
                MessageBox.Show("Please enter a value in all boxes");
            }
            else if (starttime.Length != 5 || endtime.Length != 5)
            {
                MessageBox.Show("Please enter times in 24hr format");
            }
            else if (starttimei >= endtimei)
            {
                MessageBox.Show("End Time has to be after Start Time");
            }
            else if (newS.isScheduleUnique(day,starttime,endtime) == false)
            {
                MessageBox.Show("This Schedule already exists. Please enter a unique schedule");
            }
            else
            {
                newS.updateSchedule(id, day, starttime, endtime);
                populateComboBoxes();
                tbUpdateScheduleST.ResetText();
                tbUpdateScheduleET.ResetText();
            }
        }

        private void btnScheduleDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show( "Are you sure you want to delete all records that reference this scheudle",
                "LogicOut Timetabling", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int id = Convert.ToInt32(cbDeleteSchedDay.SelectedValue);
                newS.scheduleDeleteRecord(id);
                populateComboBoxes();
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmScheduleViewcs frmSV = new frmScheduleViewcs();
            frmSV.ShowDialog();
            this.Close();
        }
    }
}
