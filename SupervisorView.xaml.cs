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
    /// Interaction logic for SupervisorView.xaml
    /// </summary>
    public partial class SupervisorView : Window
    {
        public SupervisorView()
        {
            InitializeComponent();
        }

        requestsDAL dal = new requestsDAL();
        requestsBLL r = new requestsBLL();
        DataGrid dg = new DataGrid();
        DataRowView row_selected;
        


        private void dgvFlights_Loaded(object sender, RoutedEventArgs e)
        {
            DataTable dt = dal.SelectR();
            dgvFlights.ItemsSource = dt.DefaultView;
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void txtSearch_IsKeyboardFocusedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string keywords = txtSearch.Text;

            if (keywords != null)
            {
                DataTable dt = dal.SearchAll(keywords);
                dgvFlights.ItemsSource = dt.DefaultView;
            }
            else
            {
                DataTable dt = dal.SelectR();
                dgvFlights.ItemsSource = dt.DefaultView;
            }
        }

        private void refused(object sender, RoutedEventArgs e)
        {
            txtDesc.IsEnabled = true;
        }


        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (row_selected != null)
            {
                    //row_selected[0].ToString();                    

                    r.requestNum = Convert.ToInt32(row_selected[0].ToString());
                    if (Accept.IsChecked == true)
                    {
                        r.status = "Aproved";
                    }
                    else if (Accept.IsChecked == false)
                    {
                        r.status = "Refuesed";
                        r.description = txtDesc.Text;
                    }

                
                bool success = dal.UpdateR(r);

                if (success == true)
                {
                    MessageBox.Show("Request status Successfully Updated. ");
                }

                else
                {
                    MessageBox.Show("Faild to update.");
                }

                Edit_Load();
                Clear();
            }
        }

        private void Accept_Checked(object sender, RoutedEventArgs e)
        {
            txtDesc.IsEnabled = false;
        }


        private void Edit_Load()
        {
            DataTable dt = dal.SelectR();
            dgvFlights.ItemsSource = dt.DefaultView;
        }

        private void Clear()
        {
            txtDesc.Text = "";
            if (txtSearch.Text != "Search")
                txtSearch.Text = "Search";

        }

        private void dgvFlights_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dg = (DataGrid)sender;
            row_selected = dg.SelectedItem as DataRowView;
           
        }
    }
}
