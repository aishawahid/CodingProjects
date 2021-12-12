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
    class SessionChosen
    {
        SqlConnection connection = new SqlConnection("data source=109.203.112.122;uid=aishawahid;pwd=Aisha007*;initial catalog =progrmmiAishaWahid");

        Timetable newT = new Timetable();

        //When called this method will add a record to the SessionChosen table
        public void createSessionChosen(int studentid, int sessionid)//The data needed to save a record is a StudentID and SessionID
        {
            try
            {
                string query = "INSERT INTO SessionChosen VALUES (@stid, @sid)";
                using (SqlCommand addSession = new SqlCommand(query, connection))
                {
                    addSession.Parameters.AddWithValue("@stid", studentid);
                    addSession.Parameters.AddWithValue("@sid", sessionid);
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

        //When called this method will delete a record from either SessionChosen or SessionAllocated table
        public void sessionDeleteRecord(int id, string column, string table)//The data needed to delete a record from either SessionChosen or 
        {                                                                   //SessionAllocated table is an ID and column

            try
            {
                string query = "DELETE FROM " + table + " WHERE " + column + "= @id";
                using (SqlCommand delete = new SqlCommand(query, connection))
                {
                    delete.Parameters.AddWithValue("@id", id);
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

        //When called this method will check if the choice already exists and returns a boolean value
        public bool isSessionChosenUnique(int sessionid, int studentid)//The data needed is a Student ID and Session ID
        {
            int recordCount = 1;
            string query = "SELECT Count(*) FROM SessionChosen WHERE StudentID = @stid and SessionID = @sid";
            SqlCommand unique = new SqlCommand(query, connection);
            unique.Parameters.AddWithValue("@stid", studentid);
            unique.Parameters.AddWithValue("@sid", sessionid);

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

        //This method returns a datatable containing the ID, Student Name, Room Name, Course Name, Schedule Day, StartTime and EndTime for all records
        //in either SessionChosen or SessionAllocated
        public DataTable CombineName(bool addExtraRow, string table)//If you would like an extra row at the top of the combobox that says select - bool
        {
            DataTable datatable = new DataTable();
            try
            {
                using (SqlDataAdapter retriveData = new SqlDataAdapter("SELECT " + table + ".ID AS ID, Student.Name + ' - ' +  Course.Name + ', ' +  "
                    + "Schedule.DayOfWeeks + ',' +  Schedule.StartTime + ' - ' +  Schedule.EndTime + ' - ' +  Room.Name AS Choice "
                    + "FROM " + table + " INNER JOIN Student ON " + table + ".StudentID = Student.ID "
                    + "INNER JOIN Session ON " + table + ".SessionID = Session.ID "
                    + "INNER JOIN Course ON Session.CourseID = Course.ID "
                    + "INNER JOIN Schedule ON Session.ScheduleID = Schedule.ID "
                    + "INNER JOIN Room ON Session.RoomID = Room.ID", connection))
                {
                    connection.Open();
                    retriveData.Fill(datatable);
                    if (addExtraRow == true)
                    {
                        DataRow newRow = datatable.NewRow();
                        newRow["Choice"] = "Select";
                        newRow["ID"] = 0;
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

        //This method returns a datatable of all the value in either SessionChosen or SessionAllocated table
        public DataTable ViewTable(string tablename)
        {
            using (SqlDataAdapter retriveData = new SqlDataAdapter("SELECT " + tablename + ".ID, Student.Name, Course.Name AS CourseName," 
                +" Schedule.DayOfWeeks, Schedule.StartTime, Schedule.EndTime, Room.Name FROM " + tablename
                + " INNER JOIN Student ON " + tablename + ".StudentID = Student.ID "
                + "INNER JOIN Session ON " + tablename + ".SessionID = Session.ID "
                + "INNER JOIN Course ON Session.CourseID = Course.ID "
                + "INNER JOIN Schedule ON Session.ScheduleID = Schedule.ID "
                + "INNER JOIN Room ON Session.RoomID = Room.ID", connection))
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

        //This method returns either the ID, SessionID or StudentID using the column and row in the parameter 
        public int SessionChosenIDs (int row, string column)
        {
            SqlCommand getID = new SqlCommand("SELECT * FROM SessionChosen", connection);
            using (SqlDataAdapter sda = new SqlDataAdapter(getID))
            {
                int returnvalue = 0;
                try
                {
                    DataSet scid = new DataSet();
                    sda.Fill(scid);
                    returnvalue = Convert.ToInt32(scid.Tables[0].Rows[row][column]);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                connection.Close();
                return returnvalue;
            }
        }
    }
}

