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
            checkPresentations();
            enableLevels();
        }

        private void openLevel (int receivedLevel)
        {
            GameTest newLevel = new GameTest(receivedLevel);
            this.Close();
            newLevel.Show();
        }

        private void btnLvl1_Click(object sender, RoutedEventArgs e)
        {
            openLevel(1);
        }

        private void enableLevels()
        {
            if (levelScore > 1)
                btnLvl2.IsEnabled = true;
            if (levelScore >= 5)
                btnLvl5.Visibility = Visibility.Visible;
        }

        private void checkPresentations()
        {
            if (levelScore < 2)
                btnPresentations.Visibility = Visibility.Hidden;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainMenu = new MainWindow();
            this.Close();
            mainMenu.Show();
        }

        private void btnPresentations_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
