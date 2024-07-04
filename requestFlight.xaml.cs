using StudentFlight.BLL;
using StudentFlight.DAL;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;


namespace StudentFlight
{
    /// <summary>
    /// Interaction logic for requestFlight.xaml
    /// </summary>
    public partial class requestFlight : Window
    {
        public requestFlight()
        {
            InitializeComponent();
        }

        requestsDAL dal = new requestsDAL();        
        //MainWindow u = new MainWindow();
        requestsBLL r = new requestsBLL();
        usersBLL b = new usersBLL();
        DataGrid dg;        
        DataRowView row_selected;
       // public string a = MainWindow.username(); 


        private void Search_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {            
            
        }

        static public int numRequest = 0;


        private void Request_Click(object sender, RoutedEventArgs e)
        {            
            if (MainWindow.username != "")
            {
                //DataTable dt = dal.SearchR(MainWindow.username);
                //bool i = dal.SearchR(MainWindow.username);

                //dg = (DataGrid)sender;
                // row_selected = row_selected[2].ToString();// dg.SelectedItem as DataRowView;
                // string usd = v.dgvViewRequest
                //   row_selected[0].ToString();
                //DataGrid dg = new DataGrid();
                int dc = dgvFlights.Items.Count;
                //MessageBox.Show(dc.ToString());
                if (dc < 2)
                {

                    //dg = (DataGrid)sender;
                    //row_selected = dg.SelectedItem as DataRowView;                                   
                    //row_selected[0].ToString();                    

                    r.username = MainWindow.username;

                    r.goDate = goDate.Text;
                    r.returnDate = returnDate.Text;
                    r.status = "under treatment";
                    r.From = txtFrom.Text;
                    r.To = txtTo.Text;


                    bool success = dal.InsertR(r);

                    if (success == true)
                    {
                        MessageBox.Show("Ticket Successfully Requested. ");
                    }
                    Edit_Load();
                    Clear();
                    numRequest++;
                }
                else
                {
                    MessageBox.Show("Faild to Request.");
                    Clear();
                }
                
            }
            }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void dgvFlights_Loaded(object sender, RoutedEventArgs e)
        {
            DataTable dt = dal.SearchR(MainWindow.username);
            dgvFlights.ItemsSource = dt.DefaultView;
        }

        private void Edit_Load()
        {
            DataTable dt = dal.SearchR(MainWindow.username);
            dgvFlights.ItemsSource = dt.DefaultView;
        }

        private void Clear()
        {
            txtFrom.Text = "";
            txtTo.Text = "";
            goDate.Text = "";
            returnDate.Text = "";

        }


        private void dgvFlights_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dg = (DataGrid)sender;
            row_selected = dg.SelectedItem as DataRowView;

           /* if (row_selected != null)
            {
                //row_selected[0].ToString();                    

                r.username = u.username;
                r.date = row_selected[2].ToString();
                r.status = "under treatment";
                r.Description = row_selected[1].ToString();

                bool success = dal.InsertR(r);

                if (success == true)
                {
                    MessageBox.Show("Ticket Successfully Requested. ");
                }
                else
                {
                    MessageBox.Show("Faild to Request.");
                }
            }*/
        }

        private void cancelRequest_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(row_selected[6].ToString());
            if (dgvFlights.Items.Count > 1)
            {
                if (row_selected[6].ToString()== "under treatment")
                {
                    if (row_selected != null)
                    {
                        //row_selected[0].ToString();                    

                        r.requestNum = Convert.ToInt32(row_selected[0]);

                        bool success = dal.DeleteR(r);

                        if (success == true)
                        {
                            MessageBox.Show("Request Successfully Canceld. ");
                        }
                        else
                        {
                            MessageBox.Show("Faild to cancel.");
                        }
                        Edit_Load();
                    }
                }
                else if (row_selected[6].ToString() != "under treatment")
                {
                    MessageBox.Show("You can't cancel after supervisor updated.");
                }
            }            
        }

        private void oneWay_Checked(object sender, RoutedEventArgs e)
        {            
            returnDate.IsEnabled = false;
        }

        private void twoWay_Checked(object sender, RoutedEventArgs e)
        {
            returnDate.IsEnabled = true;
        }



    }
    
}
