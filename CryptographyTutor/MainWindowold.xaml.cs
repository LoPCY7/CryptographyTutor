using FirstFloor.ModernUI.Windows.Controls;
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

namespace CryptographyTutor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowold : ModernWindow
    {
        public MainWindowold()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AESTest aesWindow = new AESTest();
            this.Hide();
            aesWindow.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            GameWindow tutor = new GameWindow(0);
            this.Hide();
            tutor.Show();
        }

        private void btnBruteForce_Click(object sender, RoutedEventArgs e)
        {
            BruteForce brForceWindow = new BruteForce();
            this.Hide();
            brForceWindow.Show();
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            TestCBC testCBC = new TestCBC();
            this.Hide();
            testCBC.Show();
        }
    }
}
