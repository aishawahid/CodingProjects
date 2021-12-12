using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timetablingLogicOut
{
    class User
    {
        SqlConnection connection = new SqlConnection("data source=109.203.112.122;uid=aishawahid;pwd=Aisha007*;initial catalog =progrmmiAishaWahid");

        //When called this method will add a record to the Staff table
        public void createUser(string username, string password, string name, int bit)//The data needed to save a record to the Staff table is a 
        {                                                                             //Username, Password, Name and bit
            try
            {
                string query = "INSERT INTO Staff VALUES (@username, @password, @name, @isAdmin)";
                using (SqlCommand addUser = new SqlCommand(query, connection))
                {
                    addUser.Parameters.AddWithValue("@username", username);
                    addUser.Parameters.AddWithValue("@password", password);
                    addUser.Parameters.AddWithValue("@name", name);
                    addUser.Parameters.AddWithValue("@isAdmin", bit);
                    connection.Open();
                    int i = addUser.ExecuteNonQuery();
                    if (i != 0)
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
        }

        //When called this method will update a record in the Staff table
        public void updateUser(string username, string password, string name, int bit)//The data needed to update a record in the Staff table is a 
        {                                                                             //Username, Password, Name and bit

            try
            {
                string query = "UPDATE Staff SET Username = @username, Pass = @password, Name = @name, IsAdmin = @isAdmin WHERE Username = @username";
                using (SqlCommand updateUser = new SqlCommand(query, connection))
                {
                    updateUser.Parameters.AddWithValue("@username", username);
                    updateUser.Parameters.AddWithValue("@password", password);
                    updateUser.Parameters.AddWithValue("@name", name);
                    updateUser.Parameters.AddWithValue("@isAdmin", bit);
                    connection.Open();
                    int i = updateUser.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Record successfully updated!");
                    }
                }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
        }

        //When called this method will delete a record from the Staff table
        public void deleteUser(string username)//The data needed to delete a record from the Staff table is an Username
        {
            try
            {
                string query = "DELETE FROM Staff WHERE Username = @user";
                using (SqlCommand delete = new SqlCommand(query, connection))
                {
                    delete.Parameters.AddWithValue("@user", username);
                    connection.Open();
                    int i = delete.ExecuteNonQuery();
                    if (i != 0)
                    {
                        MessageBox.Show("Record successfully deleted!");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
        }

        //When called this method will check if the username already exists and returns a boolean value
        public bool isUsernameUnique(string username)
        {
            int recordCount = 1;
            string query = "SELECT Count(Username) FROM Staff WHERE Username = @name";
            SqlCommand unique = new SqlCommand(query, connection);
            unique.Parameters.AddWithValue("@name", username);
            try
            {
                connection.Open();
                recordCount = Convert.ToInt32(unique.ExecuteScalar());
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

        //When called this method will check if the string tocheck has a certain character
        public bool checkCharacter(char character, string tocheck)
        {
            bool isInside = false;
            int length = tocheck.Length;
            char[] charArray = tocheck.ToCharArray();
            for(int i = 0; i < length; i++)
            {
                if(charArray[i] == character)
                {
                    isInside = true;
                }
            }
            return isInside;
        }

        //When called this method will check if the username and password exist in the same record in the Staff table
        public bool Login(string Username, string Password)
        {
            int matchesfound;
            bool found = false;
            string SqlCheck = "SELECT Count(*) FROM Staff WHERE Username = @Username and Pass = @Password ";
            SqlCommand login = new SqlCommand(SqlCheck, connection);
            login.Parameters.AddWithValue("@Username", Username);
            login.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                matchesfound = Convert.ToInt32(login.ExecuteScalar());
                if (matchesfound == 0)
                {
                    found = false;
                    MessageBox.Show("Invalid Credentials - please enter again");
                }
                else
                {
                    found = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            return found;
        }

        //When called this method will check if the user is an Admin
        public bool isAdmin(string Username, string Password)
        {
            bool isadmin = false;
            int resultBit = 0;
            string Query = "SELECT IsAdmin FROM Staff WHERE Username = @Username and Pass = @Password ";
            SqlCommand CheckAdmin = new SqlCommand(Query, connection);
            try
            {
                CheckAdmin.Parameters.AddWithValue("@Username", Username);
                CheckAdmin.Parameters.AddWithValue("@Password", Password);
                connection.Open();
                resultBit = Convert.ToInt32(CheckAdmin.ExecuteScalar());
                if (resultBit == 1)
                {
                    isadmin = true;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
            return isadmin;
        }
    }
}
