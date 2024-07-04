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
    /// Interaction logic for SupervisorMainMenu.xaml
    /// </summary>
    public partial class SupervisorMainMenu : Window
    {
        public SupervisorMainMenu()
        {
            InitializeComponent();
        }

        private void viewRequestedFlight_Click(object sender, RoutedEventArgs e)
        {
            SupervisorView v = new SupervisorView();
            v.Show();
        }

        private void logout_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
