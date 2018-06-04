using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Leader.xaml
    /// </summary>
    public partial class Leader : Window
    {
        public Leader()
        {
            InitializeComponent();
        }
        private void Lead_Back(object sender, RoutedEventArgs e)
        {
            Leaderboard lead = new Leaderboard();
            lead.Show();
            this.Close();
        }


    }
}
