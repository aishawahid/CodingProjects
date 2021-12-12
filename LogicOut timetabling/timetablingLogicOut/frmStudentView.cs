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
    public partial class frmStudentView : Form
    {
        public frmStudentView()
        {
            InitializeComponent();
            refreshGrid();
        }
        private void refreshGrid()
        {
            Timetable newt = new Timetable();
            DataTable studentDT = newt.comboBoxValues("Student", false);
            dataGridView.DataSource = studentDT;
        }

        private void btnGoToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStudent newS = new frmStudent();
            newS.ShowDialog();
            this.Close();
        }
    }
}
