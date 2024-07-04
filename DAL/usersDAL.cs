using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using StudentFlight.BLL;

namespace StudentFlight.DAL
{
    class usersDAL
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        #region Select Data From Database
        public DataTable SelectU()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                String sql = "SELECT * FROM users_table";
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
        #region Login check from Database by username
        public DataTable SearchU(string username,string password)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            MainWindow m = new MainWindow();

            try
            {
                String sql = "SELECT user_type FROM users_table WHERE username LIKE '%" + username + "%' AND " +
                    "username LIKE '%" + password + "%'";
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username",m.txtUsername);
                cmd.Parameters.AddWithValue("@password", m.txtPassword);

                if (dt.ToString() == "student")
                {
                    StudentMainMenu st = new StudentMainMenu();
                    st.Show();
                }
                else if (dt.ToString() == "supervisor")
                {
                    SupervisorMainMenu s = new SupervisorMainMenu();
                    s.Show();
                }

                else { MessageBox.Show("username or password incorrect!"); }

                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //conn.Open();
                //adapter.Fill(dt);
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
        #region user type check from Database by username
        public DataTable SearchUT(string username)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();

            try
            {
                String sql = "SELECT user_type FROM users_table WHERE username LIKE '%" + username + "%'";
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
