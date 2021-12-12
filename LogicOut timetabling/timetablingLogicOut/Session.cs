using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timetablingLogicOut
{
    class Session
    {
        SqlConnection connection = new SqlConnection("data source=109.203.112.122;uid=aishawahid;pwd=Aisha007*;initial catalog =progrmmiAishaWahid");

        //When called this method will add a record to the Course table
        public void createSession(int cid, int sid, int rid)//The data needed to add a record to the Session table are SessionID,ScheduleID and RoomID
        {
            try
            {
                string query = "INSERT INTO Session VALUES (@courseid, @scheduleid, @roomid)";
                using (SqlCommand addSession = new SqlCommand(query, connection))
                {
                    addSession.Parameters.AddWithValue("@courseid", cid);
                    addSession.Parameters.AddWithValue("@scheduleid", sid);
                    addSession.Parameters.AddWithValue("@roomid", rid);
                    connection.Open();
                    int i = addSession.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Record successfully saved!");
                    }
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
        }

        //When called this method will update a record in the Session table
        public void updateSession(int id, int cid, int sid, int rid)//The data needed to update is an ID,SessionID,ScheduleID and RoomID
        {

            try
            {
                string query = "UPDATE Session SET CourseID = @cid, ScheduleID = @sid, RoomId = @rid WHERE ID = " + id;
                using (SqlCommand updateSession = new SqlCommand(query, connection))
                {
                    updateSession.Parameters.AddWithValue("@cid", cid);
                    updateSession.Parameters.AddWithValue("@sid", sid);
                    updateSession.Parameters.AddWithValue("@rid", rid);
                    connection.Open();
                    int i = updateSession.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Record successfully updated!");
                    }
                    connection.Close();
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
        }

        //When called this method will delete a record from the Session table
        public void sessionDeleteRecord(int id)//The data needed to delete a record from the Session table is an ID
        {
            try
            {
                //When deleting from the Session table it also deletes all references to the Session ID which is referenced in the SessionChosen Table 
                //and SessionAllocated Table so the system deletes all records from the SessionChosen and SessionAllocated table that contain the 
                //Session ID being deleted
                SessionChosen newSC = new SessionChosen();
                newSC.sessionDeleteRecord(id, "SessionID", "SessionChosen");
                newSC.sessionDeleteRecord(id, "SessionID", "SessionAllocated");
                string query = "DELETE FROM Session WHERE ID = " + id;
                using (SqlCommand delete = new SqlCommand(query, connection))
                {
                    connection.Open();
                    int i = delete.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Record successfully deleted!");
                    }
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
        }

        //This method returns a boolean value that shows if the session inputted is unique or not
        public bool isSessionUnique(int cid, int sid, int rid)
        {
            int recordCount = 1;
            string query = "SELECT Count(*) FROM Session WHERE CourseID = @cid and ScheduleID = @sid and RoomID = @rid";
            SqlCommand unique = new SqlCommand(query, connection);
            unique.Parameters.AddWithValue("@cid", cid);
            unique.Parameters.AddWithValue("@sid", sid);
            unique.Parameters.AddWithValue("@rid", rid);

            try
            {
                connection.Open();
                recordCount = Convert.ToInt32(unique.ExecuteScalar());
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
            if (recordCount == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //This method returns a datatable containing the Session ID, Course Name, Day, End Time,Start Time and Room Name for all Sessions in the table
        public DataTable CombineName(bool addExtraRow)//If you would like an extra row at the top of the combobox that says select
        {
            DataTable datatable = new DataTable();
            try
            {
                using (SqlDataAdapter retriveData = new SqlDataAdapter("SELECT Session.ID, Course.Name + ' ' + Schedule.DayOfWeeks + ' ' " +
                    "+ Schedule.StartTime + ' ' + Schedule.EndTime + ' ' + Room.Name + ' ' AS Name FROM Session INNER JOIN Course ON Session.CourseID " +
                    "= Course.ID INNER JOIN Schedule ON Session.ScheduleID = Schedule.ID INNER JOIN Room ON Session.RoomID = Room.ID", connection))
                {
                    connection.Open();
                    retriveData.Fill(datatable);
                    connection.Close();
                    if (addExtraRow == true)
                    {
                        DataRow newRow = datatable.NewRow();
                        newRow["Name"] = "Select";
                        newRow["ID"] = 0;// useful for seeing if the user has or has not selected a value yet
                        datatable.Rows.InsertAt(newRow, 0);
                    }

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
            return datatable;
        }

        //This method returns a datatable of all the value in the Session table
        public DataTable ViewTable()
        {
            using (SqlDataAdapter retriveData = new SqlDataAdapter("SELECT Session.ID, Course.Name AS CourseName, Schedule.DayOfWeeks, " +
                "Schedule.StartTime, Schedule.EndTime, Room.Name AS RoomName FROM Session INNER JOIN Course ON Session.CourseID = Course.ID " +
                "INNER JOIN Schedule ON Session.ScheduleID = Schedule.ID INNER JOIN Room ON Session.RoomID = Room.ID", connection))
            {
                DataTable datatable = new DataTable();
                try
                {
                    connection.Open();
                    retriveData.Fill(datatable);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                connection.Close();
                return datatable;
            }
        }

        //This method finds the sessionID where the column equals a certain value and at a certain row
        public int SessionID(int row, int ID, string column)
        {
            SqlCommand getID = new SqlCommand("SELECT * FROM Session WHERE " + column + " = " + ID, connection);
            using (SqlDataAdapter sda = new SqlDataAdapter(getID))
            {
                DataTable datatable = new DataTable();
                int returnvalue = 0;
                try
                {
                    connection.Open();
                    DataSet scid = new DataSet();
                    sda.Fill(scid);
                    returnvalue = Convert.ToInt32(scid.Tables[0].Rows[row]["ID"]);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                connection.Close();
                
                return returnvalue;
            }
        }

        //This method counts the number of sessions where a column equals a specific value
        public int countSessions(int ID, string column)
        {
            SqlCommand getint = new SqlCommand("SELECT Count(*) FROM Session WHERE " + column + " = " + ID, connection);
            int recordCount = 0;
            try
            {
                connection.Open();
                recordCount = Convert.ToInt32(getint.ExecuteScalar());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
            return recordCount;
        }
    }
}
