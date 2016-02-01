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
    /// Interaction logic for Intro.xaml
    /// </summary>
    public partial class Intro : Window
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void btnConfirmName_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Is your name "+textBox.Text+"?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                MainWindow menuWindow = new MainWindow();
                this.Hide();
                menuWindow.Show();
            }
        }
    }
}
