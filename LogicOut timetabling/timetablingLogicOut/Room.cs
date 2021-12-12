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
    class Room
    {

        SqlConnection connection = new SqlConnection("data source=109.203.112.122;uid=aishawahid;pwd=Aisha007*;initial catalog =progrmmiAishaWahid");

        //When called this method will add a record to the Room table
        public void createRoom(string name, int maxc, int minc, string comment)//The data needed to save a record to the Course table is a Name,
        {                                                                      //Min Capacity, Max Capacity and Comment
            try
            {
                string query = "INSERT INTO Room VALUES (@name, @maxc, @minc, @comment)";
                using (SqlCommand addRoom = new SqlCommand(query, connection))
                {
                    addRoom.Parameters.AddWithValue("@name", name);
                    addRoom.Parameters.AddWithValue("@maxc", maxc);
                    addRoom.Parameters.AddWithValue("@minc", minc);
                    addRoom.Parameters.AddWithValue("@comment", comment);
                    connection.Open();
                    int i = addRoom.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Record successfully saved!");
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
        }

        //When called this method will update a record in the Room table
        public void updateRoom(int id, string name, int maxc, int minc, string comment)//The data needed to update a record in the Room table is an 
        {                                                                              //ID, Name, Min Capacity, Max Capacity and Comment

            try
            {
                string query = "UPDATE Room SET Name = @name, MaxCapacity = @maxc, MinCapacity = @minc, Comments = @comment WHERE ID = " + id;
                using (SqlCommand updateRoom = new SqlCommand(query, connection))
                {
                    updateRoom.Parameters.AddWithValue("@name", name);
                    updateRoom.Parameters.AddWithValue("@maxc", maxc);
                    updateRoom.Parameters.AddWithValue("@minc", minc);
                    updateRoom.Parameters.AddWithValue("@comment", comment);
                    connection.Open();
                    int i = updateRoom.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Record successfully updated!");
                    }
                    connection.Close();
                }
            }
            
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
        }

        //When called this method will delete a record from the Room table
        public void roomDeleteRecord(int id)//The data needed to delete a record from the Room table is an ID
        {
            try
            {
                //When deleting from the Room table it also deletes all references to the Room ID which is only referenced in the Session Table
                //so the system delete all records from the Session table that contain the Room ID being deleted
                Session newSession = new Session();
                int numofoccurences = newSession.countSessions(id, "RoomID");
                for (int i = 0; i < numofoccurences; i++)
                {
                    int sessionID = newSession.SessionID(0, id, "RoomID");
                    newSession.sessionDeleteRecord(sessionID);
                }
                string query = "DELETE FROM Room WHERE ID = " + id;
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

        public int roomValue(int roomID, string column)
        {
            string query = "SELECT (@column) FROM Room WHERE ID = (@roomid)";
            SqlCommand getValue = new SqlCommand(query, connection);
            int returnValue = 0;
            try
            {
                getValue.Parameters.AddWithValue("@column", column);
                getValue.Parameters.AddWithValue("@roomid", roomID);
                connection.Open();
                returnValue = Convert.ToInt32(getValue.ExecuteScalar());
                connection.Close();
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return returnValue;
        }

    }
}
