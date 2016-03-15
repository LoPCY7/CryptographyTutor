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
    /// Interaction logic for BruteForce.xaml
    /// </summary>
    public partial class BruteForce : UserControl
    {
        public BruteForce()
        {
            InitializeComponent();
            getCores();
        }

        private void getCores() //Get the number of the CPU cores
        {
            int coreCount = 0;
            coreCount = Environment.ProcessorCount;
            ListBoxItem itm = new ListBoxItem();
            itm.Content = "All cores (" + coreCount.ToString() + ")";
            lboxCPU.Items.Add(itm);
            for (int i = 1; i < coreCount + 1; i++)
            {
                ListBoxItem itm2 = new ListBoxItem();
                itm2.Content = i.ToString();
                lboxCPU.Items.Add(itm2);
            }
        }
    }
}
