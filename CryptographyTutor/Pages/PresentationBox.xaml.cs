using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for PresentationBox.xaml
    /// </summary>
    public partial class PresentationBox : UserControl
    {
        private string fileID;
        public PresentationBox(string id, string name)
        {
            InitializeComponent();
            fileID = id;
            setText(name);
            setIcon(id);
        }

        private void setText(string name)
        {
            txtName.Text = name;
        }

        private void setIcon(string id)
        {
            string icon = "/Images/presentationIcons/" + id + ".png";
            BitmapImage b1 = new BitmapImage();
            b1.BeginInit();
            b1.UriSource = new Uri(icon, UriKind.Relative);
            b1.EndInit();
            presentationIcon.Stretch = Stretch.Fill;
            presentationIcon.Source = b1;
        }

        private void btnOpenPresentation_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(@"Presentations\"+fileID+".pdf");
        }
    }
}
