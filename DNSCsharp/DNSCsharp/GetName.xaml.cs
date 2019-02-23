using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Net;

namespace DNSCsharp
{
    /// <summary>
    /// Interaction logic for GetName.xaml
    /// </summary>
    public partial class GetName : Window
    {
        public GetName()
        {
            InitializeComponent();
        }

        private void ButtSearch(object sender, RoutedEventArgs e)
        {
            string hn = Dns.GetHostEntry(TxtHost.Text).HostName;
            ListHost.Items.Add(hn);           

        }
    }
}
