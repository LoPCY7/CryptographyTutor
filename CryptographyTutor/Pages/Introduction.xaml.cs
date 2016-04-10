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

namespace CryptographyTutor.Pages
{
    /// <summary>
    /// Interaction logic for Introduction.xaml
    /// </summary>
    public partial class Introduction : UserControl
    {
        public Introduction()
        {
            InitializeComponent();
        }

        private void btnConfirmName_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Is your name " + txtName.Text + "?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                String playerName = txtName.Text;
                WelcomePage firstRun = (WelcomePage)Window.GetWindow(this);
                firstRun.createSave(playerName);
            }
        }
    }
}
