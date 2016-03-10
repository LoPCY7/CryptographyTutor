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
    /// Interaction logic for FinalAES.xaml
    /// </summary>
     
    public partial class FinalAES : Window
    {
        public enum Mode
        {
            ECB,
            CBC
        }

        public Mode aesMode;

        private const int Nb = 4;


        public FinalAES()
        {
            InitializeComponent();
        }
    }
}
