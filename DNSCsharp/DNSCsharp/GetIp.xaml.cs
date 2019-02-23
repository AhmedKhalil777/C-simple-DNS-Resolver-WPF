using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Media;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Net;

namespace DNSCsharp
{
    /// <summary>
    /// Interaction logic for GetIp.xaml
    /// </summary>
    public partial class GetIp : Window
    {
        public GetIp()
        {
            InitializeComponent();
        }

        private void ButtIpClick(object sender, RoutedEventArgs e)
        {
            IPAddress[] Addresses = Dns.GetHostByName(TxtIp.Text).AddressList;
            SystemSounds.Asterisk.Play();
            for (int i = 0; i < Addresses.Length; i++)
            {
                ListIp.Items.Add(Addresses[i].MapToIPv4().ToString()+"\t\t\t"+TxtIp.Text);
            }
        }
    }
}
