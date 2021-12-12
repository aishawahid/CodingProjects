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
    public partial class frmTimetableAdmin : Form
    {
        public frmTimetableAdmin()
        {
            InitializeComponent();
        }

        private void frmTimetableAdmin_Load_1(object sender, EventArgs e)
        {
            MakingTimetable newMT = new MakingTimetable();
            DataTable dt = newMT.visualTimetable();
            dataGridView1.DataSource = dt;
            User newU = new User();
            string nl = Environment.NewLine;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    if (newU.checkCharacter(',', Convert.ToString(dataGridView1.Rows[row.Index].Cells[col.Index].Value)) == true)
                    {
                        dataGridView1.Rows[row.Index].Cells[col.Index].Style.BackColor = Color.LemonChiffon;
                    }
                    else if (newU.checkCharacter(' ', Convert.ToString(dataGridView1.Rows[row.Index].Cells[col.Index].Value)) == true)
                    {
                        dataGridView1.Rows[row.Index].Cells[col.Index].Style.BackColor = Color.Khaki;
                    }
                }
            }
        }

        private void btnGoToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain newM = new frmMain();
            newM.ShowDialog();
            this.Close();
        }

        
    }
}
