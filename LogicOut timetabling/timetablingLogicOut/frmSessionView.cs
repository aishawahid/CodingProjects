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
    public partial class frmSessionView : Form
    {
        public frmSessionView()
        {
            InitializeComponent();
            refreshGrid();
        }

        private void refreshGrid()
        {
            Session newS = new Session();
            DataTable sessionDT = newS.ViewTable();
            dataGridView.DataSource = sessionDT;
        }

        private void btnGoToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSession newS = new frmSession();
            newS.ShowDialog();
            this.Close();
        }
    }
}
