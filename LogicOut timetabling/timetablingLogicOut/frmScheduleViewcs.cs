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
    public partial class frmScheduleViewcs : Form
    {
        public frmScheduleViewcs()
        {
            InitializeComponent();
            refreshGrid();
        }

        private void refreshGrid()
        {
            Timetable newt = new Timetable();
            DataTable scheduleDT = newt.comboBoxValues("Schedule" , false);
            dataGridView.DataSource = scheduleDT;
        }

        private void btnGoToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSchedule newfrmS = new frmSchedule();
            newfrmS.ShowDialog();
            this.Close();
        }
    }
}
