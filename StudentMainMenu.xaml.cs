using System;
using System.Collections.Generic;
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
    /// Interaction logic for StudentMainMenu.xaml
    /// </summary>
    public partial class StudentMainMenu : Window
    {
        public StudentMainMenu()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void requestFlight_Click(object sender, RoutedEventArgs e)
        {
            requestFlight r = new requestFlight();
            r.Show();
        }

    }
}
