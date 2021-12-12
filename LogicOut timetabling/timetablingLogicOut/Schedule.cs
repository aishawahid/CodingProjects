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
    class Schedule
    {
        SqlConnection connection = new SqlConnection("data source=109.203.112.122;uid=aishawahid;pwd=Aisha007*;initial catalog =progrmmiAishaWahid");

        //When called this method will add a record to the Schedule table
        public void createSchedule(string day, string starttime, string endtime)//The data needed to save a record to the Schedule table is a Day, 
        {                                                                       //Start Time and End Time
            try
            {
                string query = "INSERT INTO Schedule VALUES (@day, @starttime, @endtime)";
                using (SqlCommand addSchedule = new SqlCommand(query, connection))
                {
                    addSchedule.Parameters.AddWithValue("@day", day);
                    addSchedule.Parameters.AddWithValue("@starttime", starttime);
                    addSchedule.Parameters.AddWithValue("@endtime", endtime);
                    connection.Open();
                    int i = addSchedule.ExecuteNonQuery();
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

        //When called this method will update a record in the Schedule table
        public void updateSchedule(int id, string day, string starttime, string endtime)//The data needed to update a record in the Schedule table is 
        {                                                                               //an ID, Day, Start Time and End Time

            try
            {
                string query = "UPDATE Schedule SET DayOfWeeks = @day, StartTime = @starttime, EndTime = @endtime WHERE ID = " + id;
                using (SqlCommand updateSchedule = new SqlCommand(query, connection))
                {
                    updateSchedule.Parameters.AddWithValue("@day", day);
                    updateSchedule.Parameters.AddWithValue("@starttime", starttime);
                    updateSchedule.Parameters.AddWithValue("@endtime", endtime);
                    connection.Open();
                    int i = updateSchedule.ExecuteNonQuery();
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

        //When called this method will delete a record from the Schedule table
        public void scheduleDeleteRecord(int id)//The data needed to delete a record from the Schedule table is an ID
        {
            try
            {
                //When deleting from the Schedule table it also deletes all references to the Schedule ID which is only referenced in the Session Table
                //so the system delete all records from the Session table that contain the Schedule ID being deleted
                Session newSession = new Session();
                int numofoccurences = newSession.countSessions(id, "ScheduleID");
                for (int i = 0; i < numofoccurences; i++)
                {
                    int sessionID = newSession.SessionID(0, id, "ScheduleID");
                    newSession.sessionDeleteRecord(sessionID);
                }
                string query = "DELETE FROM Schedule WHERE ID = " + id;
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

        //When called this method will check if the schedule already exists and returns a boolean value
        public bool isScheduleUnique(string day, string starttime, string endtime)//The data needed is a Day, Start Time and End Time
        {
            int recordCount = 1;
            string query = "SELECT Count(DayOfWeeks) FROM Schedule WHERE DayOfWeeks = @day and StartTime = @starttime and EndTime = @endtime";
            SqlCommand unique = new SqlCommand(query, connection);
            unique.Parameters.AddWithValue("@day", day);
            unique.Parameters.AddWithValue("@starttime", starttime);
            unique.Parameters.AddWithValue("@endtime", endtime);

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

        //This method returns a datatable containing the Day, Start Time and End Time for all Schedules in the table
        public DataTable CombineName(bool addExtraRow)//If you would like an extra row at the top of the combobox that says select
        {
            DataTable datatable = new DataTable();
            try
            {
                using (SqlDataAdapter retriveData = new SqlDataAdapter("SELECT ID, DayOfWeeks +' ' + StartTime +' '+ EndTime + ' ' AS Name FROM " +
                    "Schedule", connection))
                {
                    connection.Open();
                    retriveData.Fill(datatable);
                    connection.Close();
                    if (addExtraRow == true)
                    {
                        DataRow newRow = datatable.NewRow();
                        newRow["Name"] = "Select";
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

        //When this method is called it returns the time of the record at the particular row as a string
        public string ScheduleTimeValue(int row)
        {
            SqlCommand getID = new SqlCommand("SELECT StartTime + '-' + EndTime AS Time FROM Schedule ORDER BY StartTime ASC", connection);
            string returnvalue = "";
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(getID))
                {
                    DataSet scid = new DataSet();
                    sda.Fill(scid);
                    returnvalue = Convert.ToString(scid.Tables[0].Rows[row]["Time"]);
                    return returnvalue;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
            return returnvalue;
            
        }
        
        //When this method is called it returns a string array of all the unique times in the Schedule table in ascending order
        public string[] uniqueTimes()
        {
            Timetable newT = new Timetable();
            int numofschedules = newT.NumberOfRows("Schedule");
            string[] allTimes = new string[numofschedules];
            for(int i =0; i < numofschedules; i++)
            {
                string time = ScheduleTimeValue(i);
                allTimes[i] = time;
            }
            string[] uniqueTimes = allTimes.Distinct().ToArray();
            return uniqueTimes;
        }

        //When this method is called it will find the ID of the record where the day, startime and endtime equal the values given in the parameter
        public int getID(string day, string starttime, string endtime)
        {
            int id = 0;
            string query = "SELECT ID FROM Schedule WHERE DayOfWeeks = @day and StartTime = @starttime and EndTime = @endtime";
            SqlCommand unique = new SqlCommand(query, connection);
            unique.Parameters.AddWithValue("@day", day);
            unique.Parameters.AddWithValue("@starttime", starttime);
            unique.Parameters.AddWithValue("@endtime", endtime);

            try
            {
                connection.Open();
                id = Convert.ToInt32(unique.ExecuteScalar());
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
            return id;
        }
    }
}
