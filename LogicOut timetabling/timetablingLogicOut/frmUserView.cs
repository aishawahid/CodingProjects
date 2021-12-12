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
    public partial class frmUserView : Form
    {
        public frmUserView()
        {
            InitializeComponent();
            refreshGrid();
        }
        private void refreshGrid()
        {
            Timetable newT = new Timetable();
            DataTable userDT = newT.comboBoxValues("Staff", false);
            dataGridView.DataSource = userDT;
        }

        private void btnGoToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUser newU = new frmUser();
            newU.ShowDialog();
            this.Close();
        }
    }
}
