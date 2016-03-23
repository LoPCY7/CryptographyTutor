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

namespace CryptographyTutor
{
    /// <summary>
    /// Interaction logic for Slideshow.xaml
    /// </summary>
    public partial class AESSlideshow : ModernWindow
    {
        string[] imgs;
        private int selected = 0;
        public AESSlideshow()
        {
            InitializeComponent();
            imgs = new string[68];
            for (int i = 0; i < 68; i++)
            {
                int imgNum = i + 1;
                imgs[i] = "/Images/"+ imgNum + ".png";
            }
            showImage(imgs[0], 0);
        }
        
        private void showImage(string img, int i)
        {
            BitmapImage b1 = new BitmapImage();
            b1.BeginInit();
            b1.UriSource = new Uri(img, UriKind.Relative);
            b1.EndInit();
            imageAES.Stretch = Stretch.Fill;
            imageAES.Source = b1;
        }

        //Previous Button Click
        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (selected == imgs.Length - 1)
            {
                selected = 0;
                showImage(imgs[selected], selected);

            }
            else
            {
                selected = selected + 1; showImage(imgs[selected], selected);
            }

        }
        //Next Button Click
        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (selected == 0)
            {
                selected = imgs.Length - 1;
                showImage(imgs[selected], selected);
            }
            else
            {
                selected = selected - 1; showImage(imgs[selected], selected);
            }

        }
    }
}
