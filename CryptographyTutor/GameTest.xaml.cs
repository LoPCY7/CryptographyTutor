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
    /// Interaction logic for GameTest.xaml
    /// </summary>
    public partial class GameTest : ModernWindow
    {
        private int page;
        private int gameLevel;
        private int questionsNumber;
        public GameTest(int receivedLevel)
        {
            InitializeComponent();
            page = 1;
            questionsNumber = 0;
            gameLevel = receivedLevel;
            displayPage();
        }

        private void displayPage()
        {
            if (gameLevel == 1)
            {
                questionsNumber = 4;
                if (page == 1)
                {
                    /*textBlock.Text = "Welcome to the world of Cryptography!";
                    btnQuiz.Visibility = Visibility.Hidden;
                    btnBack.IsEnabled = false;
                    btnNext.IsEnabled = true;*/
                }
                if (page == 2)
                {
                   /* textBlock.Text = "What is Cryptography?\n\n"
                        + "First of all, the word Cryptography means hidden writing.\n"
                        + "It's etymology comes from the Greek words kryptos (hidden) and "
                        + "graphein (to write).";
                    btnBack.IsEnabled = true;
                    btnNext.IsEnabled = true;*/
                }
                if (page == 3)
                {
                    /*textBlock.Text = "Cryptography is the algorithmic techniques to "
                        + "obscure the meaning of information so theat it is unreadable "
                        + "without special knowledge.\n"
                        + "Or in other words, Encryption of information!\n\n"
                        + "The opposite process is called Decryption.\n"
                        + "Decryption: The algorithm to recover original information "
                        + "from encrypted text";*/
                }
                if (page ==4)
                {
                   /* textBlock.Text = "You have now completed the first chapter of Cryptography Tutor!\n"
                        + "In order to proceed to Chapter 2: Intro to Block Ciphers, you need to completed a quiz.\n\n"
                        + "You have unlocked: Presentations Menu\n\n"
                        + "Quiz:\n"
                        + "4 questions\n"
                        + "Requirements to pass: 4/4 correct";*/
                    btnNext.IsEnabled = false;
                    btnQuiz.Visibility = Visibility.Visible;
                }
            }
            else
            {
                if (page == 1)
                {
                    /*textBlock.Text = "Hello, this tutorial is about AES." +
                        "\nAES stands for Advanced Encryption Standard." +
                        "\nIt was designed by Rijmen-Daemen in Belgium." +
                        "\nIt has 128/192/256 bit keys and 128 bit data.";
                    btnQuiz.Visibility = Visibility.Hidden;
                    btnBack.IsEnabled = false;
                    btnNext.IsEnabled = true;*/
                }
                if (page == 2)
                {
                    /*textBlock.Text = "It uses a data block of 4 columns of 4 bytes is state, " +
                    "and the key is expanded to array of words";
                    btnBack.IsEnabled = true;
                    btnNext.IsEnabled = false;
                    btnQuiz.Visibility = Visibility.Visible;*/
                }
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
            LevelWindow newLevel = new LevelWindow(gameLevel,questionsNumber);
            this.Close();
            newLevel.Show();
        }

    }
}
