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
    public partial class frmTimetable : Form
    {
        public frmTimetable()
        {
            InitializeComponent();
        }

        private void frmTimetable_Load(object sender, EventArgs e)
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
                    if(newU.checkCharacter(',', Convert.ToString(dataGridView1.Rows[row.Index].Cells[col.Index].Value)) == true)
                    {
                        //colours cell with Lemon Chiffon if there are multiple sessions
                        dataGridView1.Rows[row.Index].Cells[col.Index].Style.BackColor = Color.LemonChiffon;
                    }
                    else if (newU.checkCharacter(' ', Convert.ToString(dataGridView1.Rows[row.Index].Cells[col.Index].Value))  == true)
                    {
                        //colours cell with Khaki if there is one sessions
                        dataGridView1.Rows[row.Index].Cells[col.Index].Style.BackColor = Color.Khaki;
                    }
                }
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            this.Close();
        }
    }
}
