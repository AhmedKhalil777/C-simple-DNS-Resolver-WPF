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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DNSCsharp
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

        private void ButtClickHost(object sender, RoutedEventArgs e)
        {
            GetName gn = new GetName();
            gn.Show();
        }

        private void ButtClickIp(object sender, RoutedEventArgs e)
        {
            GetIp gi = new GetIp();
            gi.Show();
        }
    }
}
