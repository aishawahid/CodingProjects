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
    public partial class frmSessionChosenView : Form
    {
        public frmSessionChosenView()
        {
            InitializeComponent();
            refreshGrid();
        }
        private void refreshGrid()
        {
            SessionChosen newSC = new SessionChosen();
            DataTable sessionchosenDT = newSC.ViewTable("SessionChosen");
            DataTable sessionallocatedDT = newSC.ViewTable("SessionAllocated");
            dataGridView.DataSource = sessionchosenDT;
            dataGridView1.DataSource = sessionallocatedDT;
        }

        private void btnGoToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSessionChosen newSC = new frmSessionChosen();
            newSC.ShowDialog();
            this.Close();
        }
    }
}
