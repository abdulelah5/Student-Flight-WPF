using StudentFlight.BLL;
using StudentFlight.DAL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//using StudentFlight.UI;

namespace StudentFlight
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        usersDAL dal = new usersDAL();
        usersBLL b = new usersBLL();
        requestFlight r = new requestFlight();
        public static string username;


        private void Login_Click(object sender, RoutedEventArgs e)
        {
             username = txtUsername.Text;
             string password = txtPassword.Password;            

             if (username != null && password != null)
             {
                 string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
                 SqlConnection conn = new SqlConnection(myconnstrng);
                 //DataTable dt = new DataTable();                

                 try
                 {                    
                     String sql = "SELECT * FROM users_table WHERE username=@username";
                     conn.Open();
                     SqlCommand cmd = new SqlCommand(sql, conn);
                     cmd.Parameters.AddWithValue("@username", txtUsername.Text);  
                    //cmd.Parameters.AddWithValue("@password", txtPassword.Password);
                    //cmd.Parameters.AddWithValue("@user_type", user_type);

                    SqlDataReader reader = cmd.ExecuteReader();

                     if (reader.Read())
                     {
                         if (reader["password"].ToString().Equals(txtPassword.Password.ToString(), StringComparison.InvariantCulture))
                         {
                             if (reader["user_type"].ToString().Equals("student", StringComparison.InvariantCulture))
                             {
                                 StudentMainMenu st = new StudentMainMenu();
                                 st.Show();
                             }
                             else if (reader["user_type"].ToString().Equals("supervisor", StringComparison.InvariantCulture))
                             {
                                 SupervisorMainMenu s = new SupervisorMainMenu();
                                 s.Show();
                             }                            
                         }

                         else { MessageBox.Show("Password is incorrect!"); }

                        //b.username = username.ToString();
                        //r.setUsername(txtUsername.Text=);                        

                        txtUsername.Text = "";
                         txtPassword.Password = "";
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


             }
        }



        private void Login_Loaded(object sender, RoutedEventArgs e)
        {
            dal.SelectU();            
        }
    }
}
