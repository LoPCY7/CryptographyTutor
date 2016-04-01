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
    /// Interaction logic for ResultsPage.xaml
    /// </summary>
    public partial class ResultsPage : ModernWindow
    {
        private int playerScore, questionsNumber, levelScore;
        private bool passedTest;
        public ResultsPage(int score, int quesNumb, int lvlScore)
        {
            InitializeComponent();
            playerScore = score;
            questionsNumber = quesNumb;
            passedTest = false;
            levelScore = lvlScore;
            displayResults();
        }

        private void btnProceed_Click(object sender, RoutedEventArgs e)
        {
            /*GameWindow continueGame = new GameWindow(levelScore);
            this.Close();
            continueGame.Show();*/
        }

        private void displayResults()
        {
            string results = playerScore.ToString() + "/" + questionsNumber.ToString();
            lblResults.Content = results;
            btnReport.IsEnabled = false;
            if (playerScore == questionsNumber)
            {
                lblComments.Content = "Congratulations, you have passed the test!";
                passedTest = true;
            }
            else
            {
                lblComments.Content = "Too bad, you need to study more. Try again later!";
            }
            if (passedTest == true)
                levelScore = levelScore + 1;
        }
       
    }
}
