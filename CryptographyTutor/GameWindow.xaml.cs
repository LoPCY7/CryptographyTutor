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
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        public int levelScore;

public GameWindow(int gameScore)
        {
            InitializeComponent();
            levelScore = gameScore;
            enableLevels();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            LevelWindow newLevel = new LevelWindow(levelScore);
            newLevel.Show();
        }

        private void enableLevels()
        {
            if (levelScore >= 1)
                button1.IsEnabled = true;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
