using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Interaction logic for AESTest.xaml
    /// </summary>
    public partial class AESTest : Window
    {
        public int encryptionMode;
        public string encKey;

        public AESTest()
        {
            InitializeComponent();
            encryptionMode = 0;
            encKey = "";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (encryptionMode == 0)
            {
                byte[] keyArray = UTF8Encoding.UTF8.GetBytes(encKey); // 256-AES key
                byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(textBox.Text);
                RijndaelManaged rDel = new RijndaelManaged();
                rDel.Key = keyArray;
                rDel.Mode = CipherMode.ECB; // http://msdn.microsoft.com/en-us/library/system.security.cryptography.ciphermode.aspx
                rDel.Padding = PaddingMode.PKCS7; // better lang support
                ICryptoTransform cTransform = rDel.CreateEncryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                label.Content = Convert.ToBase64String(resultArray, 0, resultArray.Length);
                textBox1.Text = Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }
            else
            {
                byte[] keyArray = UTF8Encoding.UTF8.GetBytes(encKey); // AES-256 key
                byte[] toEncryptArray = Convert.FromBase64String(textBox.Text);
                RijndaelManaged rDel = new RijndaelManaged();
                rDel.Key = keyArray;
                rDel.Mode = CipherMode.ECB; // http://msdn.microsoft.com/en-us/library/system.security.cryptography.ciphermode.aspx
                rDel.Padding = PaddingMode.PKCS7; // better lang support
                ICryptoTransform cTransform = rDel.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
                label.Content = UTF8Encoding.UTF8.GetString(resultArray);
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            encryptionMode = 1;
            button.Content = "Decrypt Text";
            button2.IsEnabled = false;
            button1.IsEnabled = true;
            textBox1.Visibility = Visibility.Hidden;
            label.Content = "Decrypted Text";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            encryptionMode = 0;
            button.Content = "Encrypt Text";
            button2.IsEnabled = true;
            button1.IsEnabled = false;
            textBox1.Text = "Encrypted Text";
            textBox1.Visibility = Visibility.Visible;
            label.Content = "Encrypted Text";
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (textBox2.Text.Length==32)
            {
                encKey = textBox2.Text;
                button4.IsEnabled = false;
                button.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("Key must have 32 characters!");
            }
        }
    }
}
