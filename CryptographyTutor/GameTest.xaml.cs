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
    /// Interaction logic for GameTest.xaml
    /// </summary>
    public partial class GameTest : Window
    {
        private int page;
        public GameTest()
        {
            InitializeComponent();
            page = 1;
            displayPage();
        }

        private void displayPage()
        {
            if (page == 1)
            {
                textBlock.Text = "Hello, this tutorial is about AES." +
                    "\nAES stands for Advanced Encryption Standard." +
                    "\nIt was designed by Rijmen-Daemen in Belgium." +
                    "\nIt has 128/192/256 bit keys and 128 bit data.";
                btnQuiz.Visibility = Visibility.Hidden;
                btnBack.IsEnabled = false;
                btnNext.IsEnabled = true;
            }
            if (page==2)
                {
                    textBlock.Text = "It uses a data block of 4 columns of 4 bytes is state, "+
                    "and the key is expanded to array of words";
                btnBack.IsEnabled = true;
                btnNext.IsEnabled = false;
                btnQuiz.Visibility = Visibility.Visible;
            }

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            page--;
            displayPage();
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            page++;
            displayPage();
        }

        private void btnQuiz_Click(object sender, RoutedEventArgs e)
        {
            LevelWindow newLevel = new LevelWindow(1);
            this.Close();
            newLevel.Show();
        }

    }
}
