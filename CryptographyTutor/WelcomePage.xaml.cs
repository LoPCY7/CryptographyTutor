using FirstFloor.ModernUI.Windows.Controls;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace CryptographyTutor
{
    /// <summary>
    /// Interaction logic for WelcomePage.xaml
    /// </summary>
    public partial class WelcomePage : ModernWindow
    {

        string savePath;
        string folderSavePath;

        public WelcomePage()
        {
            InitializeComponent();
        }

        private void createSave(string playerName)
        {
            Directory.CreateDirectory(folderSavePath);
            File.Create(savePath).Close();
            TextWriter tw = new StreamWriter(savePath);
            tw.WriteLine(playerName);
            tw.Close();
        }
    }
}
