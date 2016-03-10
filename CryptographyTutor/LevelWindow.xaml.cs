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
    /// Interaction logic for LevelWindow.xaml
    /// </summary>
    public partial class LevelWindow : ModernWindow
    {
        private int levelScore;
        private bool correctAnswer;
        private int questionNumber;
        private char answerButton;
        private bool buttonsDisable;
        private int playerScore;
        private int numQuestions;
        public LevelWindow(int gameScore, int questionsNumber)
        {
            InitializeComponent();
            levelScore = gameScore;
            txtQuestion.IsReadOnly = true;
            correctAnswer = false;
            questionNumber = 1;
            buttonsDisable = false;
            playerScore = 0;
            numQuestions = questionsNumber;
            setQuestion();
        }

        private void setQuestion()
        {
            if (levelScore==1)
            {
                if (questionNumber == 1)
                {
                    txtQuestion.Text = "What is the meaning of the word Cryptography?";
                    btnA.Content = "Hidden Writing";
                    btnB.Content = "Old Writing";
                    btnC.Content = "Mathimatical Expression";
                    btnD.Content = "Linguistic Technique";
                    answerButton = 'A';
                }
                if (questionNumber == 3)
                {
                    txtQuestion.Text = "What Cryptography does?";
                    btnD.Content = "Encrypts Information";
                    btnB.Content = "Reads text";
                    btnC.Content = "Searches for information";
                    btnA.Content = "Finds names in text";
                    answerButton = 'D';
                }
                if (questionNumber == 2)
                {
                    txtQuestion.Text = "Cryptography is...";
                    btnD.Content = "Algorithmic Techniques";
                    btnB.Content = "Logarithimic Methods";
                    btnC.Content = "Cooking Recipe";
                    btnA.Content = "Literature Mirage";
                    answerButton = 'D';
                }
                if (questionNumber == 4)
                {
                    txtQuestion.Text = "What is the opposite of Encryption?";
                    btnD.Content = "Uncryption";
                    btnB.Content = "Nocryption";
                    btnC.Content = "Decryption";
                    btnA.Content = "Acryption";
                    answerButton = 'C';
                }
            }
            if (levelScore==5)
            {
                txtQuestion.Text = "Who designed the AES Cipher?";
                btnA.Content = "Rijmen-Daemen";
                btnB.Content = "Riman-Daemon";
                btnC.Content = "Rezmon-Daemen";
                btnD.Content = "Rexmen-Deman";
            }
        }

        private void btnA_Click(object sender, RoutedEventArgs e)
        {
            if (buttonsDisable == false)
            {
                if (answerButton == 'A')
                {
                    btnA.Background = Brushes.Green;
                    correctAnswer = true;
                }
                else
                    btnA.Background = Brushes.Red;
                checkAnswer();
            }
        }

        private void btnD_Click(object sender, RoutedEventArgs e)
        {
            if (buttonsDisable == false)
            {
                if (answerButton == 'D')
                {
                    btnD.Background = Brushes.Green;
                    correctAnswer = true;
                }
                else
                    btnD.Background = Brushes.Red;
                checkAnswer();
            }
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            if (buttonsDisable == false)
            {
                if (answerButton == 'C')
                {
                    btnC.Background = Brushes.Green;
                    correctAnswer = true;
                }
                else
                    btnC.Background = Brushes.Red;
                checkAnswer();
            }
        }

        private void btnB_Click(object sender, RoutedEventArgs e)
        {
            if (buttonsDisable == false)
                {
                if (answerButton == 'B')
                {
                    btnB.Background = Brushes.Green;
                    correctAnswer = true;
                }
                else
                    btnB.Background = Brushes.Red;
                checkAnswer();
            }
        }

        private void checkAnswer()
        {
            if (questionNumber == numQuestions)
            {
                btnNextQuestion.Content = "Results";
            }
            if (correctAnswer==false)
            {
                if (answerButton == 'A')
                    btnA.Background = Brushes.Green;
                if (answerButton == 'B')
                    btnB.Background = Brushes.Green;
                if (answerButton == 'C')
                    btnC.Background = Brushes.Green;
                if (answerButton == 'D')
                    btnD.Background = Brushes.Green;
            }
            else
            {
                playerScore++;
                correctAnswer = false;
            }
            buttonsDisable = true;
            btnNextQuestion.IsEnabled = true;
        }

        private void btnNextQuestion_Click(object sender, RoutedEventArgs e)
        {
            if (btnNextQuestion.Content.ToString()=="Next")
            {
                btnNextQuestion.IsEnabled = false;
                buttonsDisable = false;
                btnA.Background = Brushes.Gray;
                btnB.Background = Brushes.Gray;
                btnC.Background = Brushes.Gray;
                btnD.Background = Brushes.Gray;
                questionNumber++;
                setQuestion();
            }
            else
            {
                ResultsPage resultsPage = new ResultsPage(playerScore, numQuestions, levelScore);
                this.Close();
                resultsPage.Show();
            }
        }
    }
}
