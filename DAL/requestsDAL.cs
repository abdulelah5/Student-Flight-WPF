using StudentFlight.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StudentFlight.DAL
{
    class requestsDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        #region Select Data From Database
        public DataTable SelectR()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                String sql = "SELECT * FROM requestedFlights";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region Insert Data In Database
        public bool InsertR(requestsBLL r)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String sql = "INSERT INTO requestedFlights ([From], [To], username, goDate, returnDate, status, description) " +
                    "VALUES (@From, @To, @username, @goDate, @returnDate, @status, description)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@From", r.From);
                cmd.Parameters.AddWithValue("@To", r.To);
                cmd.Parameters.AddWithValue("@username", r.username);
                cmd.Parameters.AddWithValue("@goDate", r.goDate);
                cmd.Parameters.AddWithValue("@returnDate", r.returnDate);
                cmd.Parameters.AddWithValue("@status", r.status);
                cmd.Parameters.AddWithValue("@description", r.description);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion        
        #region Update status in Database
        public bool UpdateR(requestsBLL r)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE requestedFlights set status=@status, description=@description WHERE requestNum=@requestNum";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@requestNum", r.requestNum);
                cmd.Parameters.AddWithValue("@status", r.status);
                cmd.Parameters.AddWithValue("@description", r.description);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion
        #region Delete From Database
        public bool DeleteR(requestsBLL r)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM requestedFlights WHERE requestNum=@requestNum";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@requestNum", r.requestNum);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }


        #endregion
        #region Search from Database by username
        public DataTable SearchR(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();                       

            try
            {
                String sql = "SELECT * FROM requestedFlights WHERE username LIKE '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();                
                adapter.Fill(dt);
                                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
        #region Search from Database by username
        public DataTable SearchAll(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                String sql = "SELECT * FROM requestedFlights WHERE username LIKE '%" + keywords + "%' OR " +
                    "goDate LIKE '%" + keywords + "%' OR returnDate LIKE '%" + keywords + "%'" +
                    "OR [From] LIKE '%" + keywords + "%' OR [To] LIKE '%" + keywords + "%'" +
                    "OR description LIKE '%" + keywords + "%' OR requestNum LIKE '%" + keywords + "%'";
                
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion
    }
}
