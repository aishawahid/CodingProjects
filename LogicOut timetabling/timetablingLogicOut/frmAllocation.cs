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
    public partial class frmAllocation : Form
    {
        Session newS = new Session();
        Timetable newT = new Timetable();

        public frmAllocation()
        {
            InitializeComponent();
            populateCombobox();
        }

        private void populateCombobox()
        {
            DataTable sessionDT = newS.CombineName(true);
            cbSessions.DisplayMember = "Name";
            cbSessions.ValueMember = "ID";
            cbSessions.DataSource = sessionDT;
        }

        private void btnGoToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain newM = new frmMain();
            newM.ShowDialog();
            this.Close();
        }

        private void refreshgrid()
        {
            int sessionID = Convert.ToInt32(cbSessions.SelectedValue);
            DataTable Allocated = newT.AllocatedOrUnallocated("SessionAllocated", sessionID);
            dgvAllocated.DataSource = Allocated;
            
            DataTable Unallocated = newT.AllocatedOrUnallocated("SessionChosen", sessionID);
            dgvUnallocated.DataSource = Unallocated;
        }

        private void btnAllocated_Click(object sender, EventArgs e)
        {
            
        }

        private void cbSessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sessionID = Convert.ToInt32(cbSessions.SelectedValue);
            Timetable newT = new Timetable();
            int RoomID = newT.getRoomID(sessionID);
            Room newR = new Room();
            int min = newR.roomValue(RoomID, "MinCapacity");
            int max = newR.roomValue(RoomID, "MaxCapacity");
            label7.Text = Convert.ToString(max);
            label6.Text = Convert.ToString(min);
            refreshgrid();
        }
        
    }
}
