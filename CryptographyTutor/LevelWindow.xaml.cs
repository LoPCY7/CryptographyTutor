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
    public partial class LevelWindow : Window
    {
        public int levelScore;
        public LevelWindow(int gameScore)
        {
            InitializeComponent();
            levelScore = gameScore;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Congratulations, your answer is correct!");
            levelScore = levelScore + 1;
            GameWindow continueGame = new GameWindow(levelScore);
            this.Close();
            continueGame.Show();
        }
    }
}
