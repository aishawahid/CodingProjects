using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timetablingLogicOut
{
    public partial class frmRoom : Form
    {
        Room newR = new Room();
        Timetable newT = new Timetable();

        public frmRoom()
        {
            InitializeComponent();
            populateComboBoxes();
        }

        private void populateComboBoxes()
        {
            DataTable roomTable = newT.comboBoxValues("Room", true);
            cbRoomDelete.DisplayMember = "Name";
            cbRoomDelete.ValueMember = "ID";
            cbRoomDelete.DataSource = roomTable;
            DataTable roomTable2 = newT.comboBoxValues("Room", true);
            cbUpdateRoom.DisplayMember = "Name";
            cbUpdateRoom.ValueMember = "ID";
            cbUpdateRoom.DataSource = roomTable2;
        }

        private void btnRoomAdd_Click(object sender, EventArgs e)
        {
            string name = tbAddRoomName.Text;
            int maxc = Convert.ToInt32(tbAddRoomMaxC.Text);
            int minc = Convert.ToInt32(tbAddRoomMinC.Text);
            string comment = addRoomComment.Text;

            if(name == "" || Convert.ToString(maxc) == "" || Convert.ToString(minc) == "")
            {
                MessageBox.Show("Please enter a value in all boxes");
            }
            else if (minc < 1)
            {
                MessageBox.Show("Minimum capacity must be above 0");
            }
            else if(maxc < minc)
            {
                MessageBox.Show("Maximum capacity cannot be less that the minimum");
            }
            else if(newT.isNameUnique(name, "Room") == false )
            {
                MessageBox.Show("Please choose a unique name as this name already exists");
            }
            else if (comment.Length > 200)
            {
                MessageBox.Show("Your comment is too long");
            }
            else
            {
                newR.createRoom(name, maxc, minc, comment);
                populateComboBoxes();
                tbAddRoomName.ResetText();
                tbAddRoomMaxC.ResetText();
                tbAddRoomMinC.ResetText();
                addRoomComment.ResetText();
            }
            
        }

        private void btnUpdateUpdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbUpdateRoom.SelectedValue);
            string name = tbUpdateRoomName.Text;
            int maxc = Convert.ToInt32(tbUpdateRoomMaxC.Text);
            int minc = Convert.ToInt32(tbUpdateRoomMinC.Text);
            string comment = tbUpdateRoomComments.Text;
            string selectedName = Convert.ToString(cbUpdateRoom.Text);

            if(id == 0 || name == "" || Convert.ToString(maxc) == "" || Convert.ToString(minc) == "")
            {
                MessageBox.Show("Please enter a value into each box");
            }

            else if(newT.isNameUnique(name, "Room") == false && selectedName != name)
            {
                MessageBox.Show("Please choose a unique name as this name already exists");
            }
            else if (minc < 0)
            {
                MessageBox.Show("Minimum capacity must be above 0");
            }
            else if (maxc < minc)
            {
                MessageBox.Show("Maximum capacity cannot be less that the minimum");
            }
            else
            {
                newR.updateRoom(id, name, maxc, minc, comment);
                populateComboBoxes();
                tbUpdateRoomName.ResetText();
                tbUpdateRoomMaxC.ResetText();
                tbUpdateRoomMinC.ResetText();
                tbUpdateRoomComments.ResetText();
            }
            
        }

        private void btnRoomDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbRoomDelete.SelectedValue);
            if (id == 0)
            {
                MessageBox.Show("Please select a value");       
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete all records that reference this Room",
                    "LogicOut Timetabling", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    newR.roomDeleteRecord(id);
                    populateComboBoxes();
                }
                else if (result == DialogResult.No)
                {
                    return;
                }
            }
            
        }

        private void btnGoToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain newfrmM = new frmMain();
            newfrmM.ShowDialog();
            this.Close();
        }

        private void viewRoomBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRoomView frmRoomView = new frmRoomView();
            frmRoomView.ShowDialog();
            this.Close();
        }
    }
}
