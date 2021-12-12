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
    public partial class frmCourseView : Form
    {
        public frmCourseView()
        {
            InitializeComponent();
            refreshgrid();
        }
        public void refreshgrid()
        {
            Timetable newt = new Timetable();
            DataTable CourseDT = newt.comboBoxValues("Course" , false);
            dataGridView.DataSource = CourseDT;
        }

        private void btnGoToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCourse newfrmC = new frmCourse();
            newfrmC.ShowDialog();
            this.Close();
        }
    }
}
