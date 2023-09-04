using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactForm.Classes
{
    internal class ContactClass
    {

        // getter and setter for the contact class
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }
        public string? Address { get; set; }
        public string? ContactNo { get; set; }
        public string Gender { get; set; }

        // connection string

        static string _connString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        // select method

        public DataTable Select()
        {
            // database connection
            SqlConnection conn = new SqlConnection(_connString);
            DataTable dt = new DataTable();
            try
            {
                // sql query
                string sql = "SELECT * FROM tbl_contact";
                // creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                // creating sql data adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                // throw message if any error occurs
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // closing connection
                conn.Close();
            }
            return dt;
        }

        // insert method

        public bool Insert(ContactClass cont) 
        {
        
            // creating default return type and setting its value to false
            bool isSuccess = false;
            // database connection
            SqlConnection conn = new SqlConnection(_connString);
           
            try
            {
                // sql query
                string sql = "INSERT INTO tbl_contact (FirstName, " +
                                                       "MiddleName," +
                                                       "LastName," +
                                                       "Address," +
                                                       "ContactNo," +
                                                       "Gender)" +
                                                       "VALUES (" +
                                                       "@firstName," +
                                                       "@MiddleName," +
                                                       "@LastName," +
                                                       "@Address," +
                                                       "@ContactNo," +
                                                       "@Gender)";
                // creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                // creating parameters to add data
                cmd.Parameters.AddWithValue("@firstName", cont.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", cont.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", cont.LastName);
                cmd.Parameters.AddWithValue("@Address", cont.Address);
                cmd.Parameters.AddWithValue("@ContactNo", cont.ContactNo);
                cmd.Parameters.AddWithValue("@Gender", cont.Gender);

                // open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                // if the query runs successfully then the value of rows will be greater than 0 else it will be less than 0
                if (rows > 0)
                {
                    // query successfull
                    isSuccess = true;
                }
                else
                {
                    // query failed
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                // throw message if any error occurs
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // closing connection
                conn.Close();
            }

            return isSuccess;
        
        }

        // update method

        public bool Update(ContactClass cont) 
        { 
        
            // creating default return type and setting its value to false
            bool isSuccess = false;
            // database connection
            SqlConnection conn = new SqlConnection(_connString);
            // creating sql command using sql and conn
            try 
            {

                string sql = "UPDATE tbl_contact SET FirstName=@FirstName," +
                                                     "MiddleName=@MiddleName," +
                                                     "LastName=@LastName," +
                                                     "Address=@Address," +
                                                     "ContactNo=@ContactNo," +
                                                     "Gender=@Gender" +
                                                     "WHERE" +
                                                     "ContactID=@ContactID";
                // creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                // creating parameters to add data
                cmd.Parameters.AddWithValue("@firstName", cont.FirstName);
                cmd.Parameters.AddWithValue("@MiddleName", cont.MiddleName);
                cmd.Parameters.AddWithValue("@LastName", cont.LastName);
                cmd.Parameters.AddWithValue("@Address", cont.Address);
                cmd.Parameters.AddWithValue("@ContactNo", cont.ContactNo);
                cmd.Parameters.AddWithValue("@Gender", cont.Gender);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                // if the query runs successfully then the value of rows will be greater than 0 else it will be less than 0
                if (rows > 0)
                {
                    // query successfull
                    isSuccess = true;
                }
                else
                {
                    // query failed
                    isSuccess = false;
                }
            
            }
            catch (Exception ex)
            {
                // throw message if any error occurs
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // closing connection
                conn.Close();
            }


            return isSuccess;
        
        }


        // delete method

        public bool Delete(ContactClass cont) 
        { 
        
            // creating default return type and setting its value to false
            bool isSuccess = false;
            // database connection
            SqlConnection conn = new SqlConnection(_connString);
            // creating sql command using sql and conn
            try
            {
                string sql = "DELETE FROM tbl_contact WHERE ContactID=@ContactID";
                // creating sql command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                // creating parameters to add data
                cmd.Parameters.AddWithValue("@ContactID", cont.ContactId);
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                // if the query runs successfully then the value of rows will be greater than 0 else it will be less than 0
                if (rows > 0)
                {
                    // query successfull
                    isSuccess = true;
                }
                else
                {
                    // query failed
                    isSuccess = false;
                }
            
            }
            catch (Exception ex)
            {
                // throw message if any error occurs
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // closing connection
                conn.Close();
            }
        
            return isSuccess;
        }
    }
}
