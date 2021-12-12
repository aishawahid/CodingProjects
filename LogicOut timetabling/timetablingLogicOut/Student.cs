using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timetablingLogicOut
{
    class Student
    {
        SqlConnection connection = new SqlConnection("data source=109.203.112.122;uid=aishawahid;pwd=Aisha007*;initial catalog =progrmmiAishaWahid");

        //When called this method will add a record to the Student table
        public void createStudent(string name, string phonenum, string email)//The data needed to save a record is a Name, Phonenum and Email
        {
            try
            {
                string query = "INSERT INTO Student VALUES (@name, @phonenum, @email)";
                using (SqlCommand addStudent = new SqlCommand(query, connection))
                {
                    addStudent.Parameters.AddWithValue("@name", name);
                    addStudent.Parameters.AddWithValue("@phonenum", phonenum);
                    addStudent.Parameters.AddWithValue("@email", email);
                    connection.Open();
                    int i = addStudent.ExecuteNonQuery();
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

        //When called this method will update a record in the Student table
        public void updateStudent(int id, string name, string phonenum, string email)//The data needed to update a record in the Student table is an 
        {                                                                            //ID, Name, Phonenum and Email

            try
            {
                string query = "UPDATE Student SET Name = @name, ContactNum = @phonenum, ContactEmail = @email WHERE ID = " + id;
                using (SqlCommand updateStudent = new SqlCommand(query, connection))
                {
                    updateStudent.Parameters.AddWithValue("@name", name);
                    updateStudent.Parameters.AddWithValue("@phonenum", phonenum);
                    updateStudent.Parameters.AddWithValue("@email", email);
                    connection.Open();
                    int i = updateStudent.ExecuteNonQuery();
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

        //When called this method will delete a record from the Student table
        public void studentDeleteRecord(int id)//The data needed to delete a record from the Student table is an ID
        {
            try
            {
                //When deleting from the Student table it also deletes all references to the Student ID which is referenced in the SessionChosen and 
                //Session Allocated Tables so the system delete all records from theses table that contain the Student ID being deleted
                SessionChosen newSC = new SessionChosen();
                newSC.sessionDeleteRecord(id, "StudentID", "SessionAllocated");
                newSC.sessionDeleteRecord(id, "StudentID", "SessionChosen");
                string query = "DELETE FROM Student WHERE ID = " + id;
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
    }
}
