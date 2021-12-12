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
    
    class Timetable
    {
        SqlConnection connection = new SqlConnection("data source=109.203.112.122;uid=aishawahid;pwd=Aisha007*;initial catalog =progrmmiAishaWahid");

        //This method finds the number of rows in a table
        public int NumberOfRows(string tablename)
        {
            int recordCount = 0;
            try
            {
                string query = "SELECT Count(*) FROM (@tablename)";
                using (SqlCommand countRows = new SqlCommand(query, connection))
                {
                    countRows.Parameters.AddWithValue("@tablename", tablename);
                    connection.Open();
                    recordCount = countRows.ExecuteNonQuery();
                    if (recordCount != 0)
                    {
                        MessageBox.Show("Record successfully saved!");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
            return recordCount;
        }

        //This method returns a datatable containing the ID and Name for all records in the table
        public DataTable comboBoxValues(string table, bool addExtraRow)//If you would like an extra row at the top of the combobox that says select
        {
            DataTable datatable = new DataTable();
            try
            {
                using (SqlDataAdapter retriveData = new SqlDataAdapter("SELECT * FROM " + table, connection))
                {
                    connection.Open();
                    retriveData.Fill(datatable);
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

        //When called this method will check if the name already exists in the table and returns a boolean value
        public bool isNameUnique(string Name, string Table)
        {
            int recordCount = 1;
            string query = "SELECT Count(Name) FROM " + Table + " WHERE Name = @name";
            SqlCommand unique = new SqlCommand(query, connection);
            unique.Parameters.AddWithValue("@name", Name);
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

        //This method adds students to the Session Allocated table
        public void addAllocated(int studentID, int sessionID)
        {
            string query = "INSERT INTO SessionAllocated VALUES(@studentID, @sessionID)";
            SqlCommand addrecord = new SqlCommand(query, connection);
            try
            {
                addrecord.Parameters.AddWithValue("@studentID", studentID);
                addrecord.Parameters.AddWithValue("@sessionID", sessionID);
                connection.Open();
                addrecord.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
        }

        //This method find the roomID where the Session ID equals the value in the parameter
        public int getRoomID(int sessionID)
        {
            int RoomID = 0;
            SqlCommand getid = new SqlCommand("SELECT RoomID FROM Session WHERE ID = " + sessionID, connection);
            try
            {
                connection.Open();
                RoomID = Convert.ToInt32(getid.ExecuteScalar());
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
            return RoomID;
        }

        //allocates all sessions possible
        public void sessionAllocated()
        {
            DataTable dtsessionChosen = returnSessionsChosen(); // filling the data table with all unallocated sessions
            List<int> lstSessionId = fillSessions(dtsessionChosen); // getting unique session ids from dtsessionChosen and copying them into dynamic list. 
            //Used List instead of arrays as number of sessionsId returned is not known beforehand.
            int listLength = lstSessionId.Count();
            if (listLength != 0)
            {
                int sessionIdIndex = 0;
                int minCap = getRoomCapacity(true, lstSessionId[sessionIdIndex]); //getting minimum room cappacity from room table for first sessionId from Room table through inner join in Room and session table
                int maxCap = getRoomCapacity(false, lstSessionId[sessionIdIndex]);// getting maximum room capacity in same manner
                allocation(dtsessionChosen, minCap, maxCap, lstSessionId, sessionIdIndex); //calling recursive method to allocate all the sessions as per the capacity ofthe room in the session is scheduled.
            }

        }

        //returns a datatable of the records stored in SessionChosen table
        public DataTable returnSessionsChosen()
        {
            DataTable dtsessionChosen = new DataTable();
            string query = "SELECT StudentId, SessionId FROM sessionChosen ORDER BY SessionId";
            SqlDataAdapter retriveData = new SqlDataAdapter(query, connection);
            try
            {
                retriveData.Fill(dtsessionChosen);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dtsessionChosen;
        }

        //compares the session ids of every row to get a list of unique ones
        public List<int> fillSessions(DataTable dtSessionChosen)
        {
            List<int> sessionIdList = new List<int>();

            int sessionId;
            for (int i = 0; i < dtSessionChosen.Rows.Count; i++)
            {
                sessionId = Convert.ToInt32(dtSessionChosen.Rows[i]["SessionId"]);
                sessionIdList.Add(sessionId);

                for (int j = i + 1; j < dtSessionChosen.Rows.Count; j++)
                {
                    if (sessionId != Convert.ToInt32(dtSessionChosen.Rows[j]["SessionId"]))
                    {
                        j = dtSessionChosen.Rows.Count; //instead of  using break
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            return sessionIdList;
        }

        //returns either the maximum or minimum room capacity
        public int getRoomCapacity(bool isMinCap, int sessionId)
        {
            int min_maxCap = 0;
            string query = "";
            if (isMinCap == true) //if true then returning values for minimum capacity column
            {
                query = "SELECT minCapacity FROM Room, Session, sessionChosen WHERE sessionChosen.sessionId=@sessionId AND Room.Id=Session.roomId " +
                    "AND Session.Id=sessionChosen.sessionId";
            }
            else //max is wanted
            {
                query = "SELECT maxCapacity FROM Room, Session, sessionChosen WHERE sessionChosen.sessionId=@sessionId AND Room.Id=Session.roomId " +
                    "AND Session.Id=sessionChosen.sessionId";
            }

            SqlCommand selectRoom = new SqlCommand(query, connection);
            selectRoom.Parameters.AddWithValue("@sessionId", sessionId);
            try
            {
                connection.Open();
                min_maxCap = Convert.ToInt32(selectRoom.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            return min_maxCap;
        }

        //This method find the current capacity of a class by counting the number of records with the sessionID in SessionAllocated
        public int CurrentCapcaity(int sessionID)
        {
            SqlCommand countStudents = new SqlCommand("SELECT COUNT(*) FROM SessionAllocated WHERE SessionID = " + sessionID, connection);
            try
            {
                connection.Open();
                int currentCapacity = Convert.ToInt32(countStudents.ExecuteScalar());
                connection.Close();
                return currentCapacity;
            }
            catch (Exception e)
            {
                MessageBox.Show("1");
                MessageBox.Show(e.Message);
            }
            return -1;
        }

        //This method counts the number of allocations in SessionAllocated
        public int countAllocations()
        {
            SqlCommand getint = new SqlCommand("SELECT Count(*) FROM SessionAllocated", connection);
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

        //This method returns the SessionID using the row in the parameter fron SessionAllocated
        public int SessionAllocatedIDs(int row)
        {
            SqlCommand getID = new SqlCommand("SELECT * FROM SessionAllocated", connection);
            using (SqlDataAdapter sda = new SqlDataAdapter(getID))
            {
                int returnvalue = 0;
                try
                {
                    DataSet scid = new DataSet();
                    sda.Fill(scid);
                    returnvalue = Convert.ToInt32(scid.Tables[0].Rows[row]["SessionID"]);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                connection.Close();
                return returnvalue;
            }
        }

        //When this method is called it returns the time of the record at the particular row as a string
        public string ScheduleTimeValue(int ID, string row)
        {
            SqlCommand getstring = new SqlCommand("SELECT " + row + " FROM Schedule WHERE ID = " +ID, connection);
            string returnvalue = "";
            try
            {
                connection.Open();
                returnvalue = Convert.ToString(getstring.ExecuteScalar());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
            return returnvalue;

        }

        //this method checks to see if 2 given sesssion's timings overlap
        public bool scheduleOverlap(int sessionID1, int sessionID2)
        {
            bool scheduleOverlap = false;
            string schedule1st = ScheduleTimeValue(sessionID1, "StartTime");
            string schedule1et = ScheduleTimeValue(sessionID1, "EndTime");
            string schedule2st = ScheduleTimeValue(sessionID2,"StartTime");
            string schedule2et = ScheduleTimeValue(sessionID2, "EndTime");
            DateTime st1 = Convert.ToDateTime(schedule1st);
            DateTime et1 = Convert.ToDateTime(schedule1et);
            DateTime st2 = Convert.ToDateTime(schedule2st);
            DateTime et2 = Convert.ToDateTime(schedule2et);

            if (et1 > st2)
            {
                scheduleOverlap = true;
            }
            else if (st1 < et2)
            {
                scheduleOverlap = true;
            }
            else
            {
                scheduleOverlap = false;
            }
            return scheduleOverlap;

        }

        //This method takes 2 session IDs to see if they share the same room
        public bool roomOverlap(int sessionID1, int sessionID2)
        {
            bool roomClash = false;
            int room1 = getRoomID(sessionID1);
            int room2 = getRoomID(sessionID2);

            if(room1 == room2)
            {
                roomClash = true;
            }
            else
            {
                roomClash = false;
            }

            return roomClash;
        }

        //finds out if there are sessions that are already allocated too that clash with the one we are trying to allocate to
        public bool clash(int sessionID)
        {
            bool sessionIDofOverlap = false;
            int noOfAllocations = countAllocations();
            for(int i =0; i< noOfAllocations; i++)
            {
                int sessionIDi = SessionAllocatedIDs(i);
                bool result1 = scheduleOverlap(sessionID, sessionIDi);
                bool result2 = roomOverlap(sessionID, sessionIDi);
                if( result1 == true && result2 == true)
                {
                    sessionIDofOverlap = true;
                }
                else
                {
                    sessionIDofOverlap = false;
                }
            }
            return sessionIDofOverlap;
        }

        //recursive allocation method that allocates 1 session at a time
        public void allocation(DataTable dtsessionChosen, int minCap, int maxCap, List<int> lstSessionId, int sessionIdIndex)
        {
            DataTable dtAllocated = new DataTable();
            int recordsToAllocate = 0;
            int sessionId = lstSessionId[sessionIdIndex];
            int numofsessions = lstSessionId.Count();
            int currentCapacity = CurrentCapcaity(sessionId);
            DataTable dtSessionsToAllocate = fillSessionsToAllocate(dtsessionChosen, sessionId);// getting rows from dtsessionChosen only matching
                                                                                            //sessionId read from lstSessionId on sessionIndex
            int sessionCounter = dtSessionsToAllocate.Rows.Count;
            SessionChosen newSC = new SessionChosen();

            if (sessionCounter + currentCapacity < minCap)
            {
                MessageBox.Show("There are not enough students for this class ");
                recordsToAllocate = 0;
            }
            else if (sessionCounter + currentCapacity > maxCap)
            {
                MessageBox.Show("This class is full");
                recordsToAllocate = maxCap;
            }
            else if (clash(sessionId) == true)
            {
                MessageBox.Show("There is a clash - another session is already running in the same room and at the same time");
                recordsToAllocate = 0;
            }
            else
            {
                recordsToAllocate = sessionCounter;
            }

            if (recordsToAllocate > 0)
            {
                int studentid = 0;
                int sessionid = 0;
                for (int count = 0; count < recordsToAllocate; count++)
                {
                    if (dtAllocated.Columns.Count == 0)
                    {
                        dtAllocated.Columns.Add("StudentId", typeof(int));
                        dtAllocated.Columns.Add("SessionId", typeof(int));
                    }
                    DataRow dRow = dtAllocated.NewRow();
                    
                    dRow["StudentId"] = dtSessionsToAllocate.Rows[count]["StudentId"];
                    dRow["SessionId"] = dtSessionsToAllocate.Rows[count]["SessionId"];
                    dtAllocated.Rows.Add(dRow);
                    studentid = Convert.ToInt32(dtSessionsToAllocate.Rows[count]["StudentId"]);
                    sessionid = Convert.ToInt32(dtSessionsToAllocate.Rows[count]["SessionId"]);
                    Console.WriteLine(studentid + " " + sessionid);
                    //insert into Allocation table
                    addAllocated(Convert.ToInt32(dtAllocated.Rows[count]["studentId"]), Convert.ToInt32(dtAllocated.Rows[count]["SessionId"]));
                    // method to add rows in the sessionAllocated table if allocation is possible
                    int sessionchosenid = findsessionchosenid(sessionid, studentid);
                    deleteRecordSC(sessionchosenid);//delete from sessionChosen table for sessionchosenId
                }
                dtsessionChosen = returnSessionsChosen(); //updating dtsessionChosen due to removal of rows allocated
            }
            if ((numofsessions - 1) != sessionIdIndex)
            {
                sessionIdIndex++;
                minCap = getRoomCapacity(true, lstSessionId[sessionIdIndex]);
                maxCap = getRoomCapacity(false, lstSessionId[sessionIdIndex]);
                allocation(dtsessionChosen, minCap, maxCap, lstSessionId, sessionIdIndex);
                //calling recursive method for next sessionId on sessionIndex inside lstSessionId
            }

        }

        //returns datatable that contains the records to allocate for the session given in the parameters
        public static DataTable fillSessionsToAllocate(DataTable dtSessionChosen, int sessionId)
        {
            DataTable dtTemp = new DataTable();
            dtTemp = dtSessionChosen.Clone();//copying the structure of dtSessionChosen only without any data.

            for (int i = 0; i < dtSessionChosen.Rows.Count; i++)
            {
                if (sessionId == Convert.ToInt32(dtSessionChosen.Rows[i]["SessionId"]))
                {
                    DataRow dRow = dtSessionChosen.Rows[i];
                    dtTemp.ImportRow(dRow);
                }
            }
            return dtTemp;
        }

        //This method deletes records from SessionChosen
        public void deleteRecordSC(int id)
        {
            try
            {
                string query = "DELETE FROM SessionChosen WHERE ID = " + id;
                using (SqlCommand delete = new SqlCommand(query, connection))
                {
                    connection.Open();
                    delete.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
        }

        //This method returns a datatable containing the Student Name, Student Num, Student Email for all records in the table
        public DataTable AllocatedOrUnallocated(string table, int sessionID)
        {
            string query = "SELECT Student.Name, Student.ContactNum AS ContactNumber, Student.ContactEmail AS ContactEmail " +
                "FROM " + table + " INNER JOIN Student ON " + table + ".StudentID = Student.ID WHERE SessionID = " + sessionID;
            using (SqlDataAdapter retriveData = new SqlDataAdapter(query, connection))
            {
                DataTable datatable = new DataTable();
                try
                {
                    retriveData.Fill(datatable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();
                return datatable;
            }
        }

        //finds id of record in sessionchosentable
        public int findsessionchosenid(int sessionid, int studentid)
        {
            int id = 0;
            string query = "SELECT ID FROM SessionChosen WHERE SessionID = @SID and StudentID = @STID";
            SqlCommand unique = new SqlCommand(query, connection);
            unique.Parameters.AddWithValue("@STID", studentid);
            unique.Parameters.AddWithValue("@SID", sessionid);

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
