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
    class Course
    {
        SqlConnection connection = new SqlConnection("data source=109.203.112.122;uid=aishawahid;pwd=Aisha007*;initial catalog =progrmmiAishaWahid");

        //When called this method will add a record to the Course table
        public void createCourse(string name)//The data needed to save a record to the Course table is a Name
        {
            try
            {
                string query = "INSERT INTO Course VALUES (@name)";
                using (SqlCommand addSchedule = new SqlCommand(query, connection))
                {
                    addSchedule.Parameters.AddWithValue("@name", name);
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

        }

        //When called this method will update a record in the Course table
        public void updateCourse(int id, string name)//The data needed to update a record in the Course table is an ID and a Name
        {

            try
            {
                string query = "UPDATE Course SET Name = @name WHERE ID = " + id;
                using (SqlCommand updateSchedule = new SqlCommand(query, connection))
                {
                    updateSchedule.Parameters.AddWithValue("@name", name);
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
        }

        //When called this method will delete a record from the Course table
        public void courseDeleteRecord(int id)//The data needed to delete a record from the Course table is an ID
        {
            try
            {
                //When deleting from the Course table it also deletes all references to the Course ID which is only referenced in the Session Table
                //so the system delete all records from the Session table that contain the Course ID being deleted
                Session newSession = new Session();
                int numofoccurences = newSession.countSessions(id, "CourseID");
                for (int i = 0; i < numofoccurences; i++)
                {
                    int sessionID = newSession.SessionID(0, id, "CourseID");
                    newSession.sessionDeleteRecord(sessionID);
                }

                string query = "DELETE FROM Course WHERE ID = " + id;
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
        }
    }
}
