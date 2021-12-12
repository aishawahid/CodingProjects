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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUser frmUser = new frmUser();
            frmUser.ShowDialog();
            this.Close();
        }

        private void btnSchedules_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSchedule frmSchedule = new frmSchedule();
            frmSchedule.ShowDialog();
            this.Close();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRoom frmRoom = new frmRoom();
            frmRoom.ShowDialog();
            this.Close();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudent frmStudent = new frmStudent();
            frmStudent.ShowDialog();
            this.Close();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCourse frmCourse = new frmCourse();
            frmCourse.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void btnSession_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSession frmSession = new frmSession();
            frmSession.ShowDialog();
            this.Close();
        }

        private void btnChoices_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSessionChosen frmSessionChosen = new frmSessionChosen();
            frmSessionChosen.ShowDialog();
            this.Close();
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAllocation frmA = new frmAllocation();
            frmA.ShowDialog();
            this.Close();
        }

        private void btnTimetable_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmTimetableAdmin frmT = new frmTimetableAdmin();
            frmT.ShowDialog();
            this.Close();
        }
    }
}
