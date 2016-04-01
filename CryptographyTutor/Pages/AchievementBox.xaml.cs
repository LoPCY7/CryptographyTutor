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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CryptographyTutor.Pages
{
    /// <summary>
    /// Interaction logic for AchievementBox.xaml
    /// </summary>
    public partial class AchievementBox : UserControl
    {
        public AchievementBox(string name, string description, string score)
        {
            InitializeComponent();
            setText(name, description, score);
        }

        private void setText(string name, string description, string score)
        {
            txtName.Text = name;
            txtDescription.Text = description;
            txtScore.Text = "Score: " + score;
        }
    }
}
