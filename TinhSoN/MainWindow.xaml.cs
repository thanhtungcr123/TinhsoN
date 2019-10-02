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

namespace TinhSoN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int n;
        float s = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OUT_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            n = int.Parse(txtNhap.Text);
            float s = 0;
            while (n <= 0) ;
            for (int i = 1; i <= n; i++)
            {
                s += 1 / (float)i;
            }
            MessageBox.Show("Tong: " + s);
        }
                 
    }
}
