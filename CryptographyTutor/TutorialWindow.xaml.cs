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
using System.Windows.Shapes;

namespace CryptographyTutor
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class TutorialWindow : ModernWindow
    {
        public TutorialWindow(String playerName)
        {
            InitializeComponent();
            initialiseText(playerName);
        }

        private void initialiseText(String playerName)
        {
            textBlock.Text = "Hello, " + playerName+ 
                "\nThis is a tutor abou Cryptography."+
                "\nIts purpose is to teach you about Block Ciphers.";
        }
        private void btnProceed_Click(object sender, RoutedEventArgs e)
        {
            GameWindow tutor = new GameWindow(0);
            this.Close();
            tutor.Show();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
