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

namespace CryptographyTutor.Pages
{
    /// <summary>
    /// Interaction logic for AESInspector.xaml
    /// </summary>
    public partial class AESInspector : UserControl
    {
        string curDir;

        public AESInspector()
        {
            InitializeComponent();
            string startPath = Directory.GetCurrentDirectory();
            string filepath = System.IO.Path.Combine(startPath, "AESInspector.html");
            aesBrowser.Navigate(new Uri(filepath));
        }
    }
}
