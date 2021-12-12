using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timetablingLogicOut
{
    class MakingTimetable
    {
        SqlConnection connection = new SqlConnection("data source=109.203.112.122;uid=aishawahid;pwd=Aisha007*;initial catalog =progrmmiAishaWahid");

        Schedule newS = new Schedule();
        Session newSesh = new Session();

        //This method gets the Course Name and Room Name of the session using the ScheduleID and row and return it as a string
        public string SessionName(int row, int scheduleID)
        {
            using (SqlDataAdapter retriveData = new SqlDataAdapter("SELECT Course.Name  + ' ' + Room.Name + ' ' AS Name FROM Session" +
                " INNER JOIN Course ON Session.CourseID = Course.ID INNER JOIN Room ON Session.RoomID = Room.ID INNER JOIN Schedule ON" + 
                " Session.ScheduleID = Schedule.ID WHERE Schedule.ID = " + scheduleID, connection))
            {
                string returnvalue = "";
                try
                {
                    DataSet scid = new DataSet();
                    retriveData.Fill(scid);
                    returnvalue = Convert.ToString(scid.Tables[0].Rows[row]["Name"]);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                return returnvalue;
            }
        }

        //This method returns a string of all the Sessions that reference a particular Schedule
        public string isThereASession(int ID)
        {
            int numOfSessions = newSesh.countSessions(ID, "ScheduleID");
            string final = "";
            for (int j = 0; j < numOfSessions; j++)
            {
                string sessionName = Convert.ToString(SessionName(j, ID));
                string nl = Environment.NewLine;
                if (final != "")
                {
                    final = final + "," + nl + sessionName;
                }
                else
                {
                    final = sessionName;
                }
                
            }
            return final;
        }

        //This method checks if there is a schedule for the Time and Day and returns a string to input into the timetable if there is
        public string isThereASchedule(string time, string currentDay)
        {
            string[] times = Regex.Split(time, "-");
            string StartTime = times[0];
            string EndTime = times[1];
            string returnName = "";

                if(newS.isScheduleUnique(currentDay,StartTime,EndTime) == false)// then schedule exists
                {
                    int ID = newS.getID(currentDay, StartTime, EndTime);
                    returnName = isThereASession(ID); // then finds out if there is a session allocated to the schedule
                }
            return returnName;
        }
        
        //This method returns a datatable which stores values of the Rooms and Courses of Sessions in relation to their Schedules
        public DataTable visualTimetable()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("Time");
            dt.Columns.Add("Monday");
            dt.Columns.Add("Tuesday");
            dt.Columns.Add("Wednesday");
            dt.Columns.Add("Thursday");
            dt.Columns.Add("Friday");

            string[] times = newS.uniqueTimes();
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            for (int i = 0; i < times.Length; i++)
            {
                DataRow newRow = dt.NewRow();
                newRow["Time"] = times[i];
                
                for (int j = 0; j < days.Length; j++)
                {
                    string currentDay = days[j];
                    string entry = isThereASchedule(times[i],currentDay);
                    newRow[currentDay] = entry;
                    
                }
                dt.Rows.Add(newRow);

            }
            return dt;
        }
    }
}

