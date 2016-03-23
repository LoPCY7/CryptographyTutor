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
using System.Security.Cryptography;
using System.IO;

namespace CryptographyTutor.Pages
{
    /// <summary>
    /// Interaction logic for EncryptionAES.xaml
    /// </summary>
    public partial class AESSim : UserControl
    {
        public AESSim()
        {
            InitializeComponent();
            rbtnEncryption.IsChecked = true;
            txtKey.Mask= "&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&";
        }

        private string encrypt(string inputText, string AESKey, string AESIV)
        {
            RijndaelManaged aes = new RijndaelManaged();
            aes.BlockSize = 128;
            if (rbtn128.IsChecked == true)
                aes.KeySize = 128;
            else if (rbtn192.IsChecked == true)
                aes.KeySize = 192;
            else
                aes.KeySize = 256;
            aes.Padding = PaddingMode.PKCS7;
            if (rbtnECB.IsChecked == true)
                aes.Mode = CipherMode.ECB;
            else
                aes.Mode = CipherMode.CBC;

            aes.Key = System.Text.Encoding.UTF8.GetBytes(AESKey);

            if (rbtnCBC.IsChecked == true)
                aes.IV = System.Text.Encoding.UTF8.GetBytes(AESIV);

            ICryptoTransform encrypt = aes.CreateEncryptor();
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptStream = new CryptoStream(memoryStream, encrypt, CryptoStreamMode.Write);

            byte[] text_bytes = System.Text.Encoding.UTF8.GetBytes(inputText);

            cryptStream.Write(text_bytes, 0, text_bytes.Length);
            cryptStream.FlushFinalBlock();

            byte[] encrypted = memoryStream.ToArray();

            //Debug.Log("byte :" + encrypted[0]);
            return (System.Convert.ToBase64String(encrypted));
        }

        private string decrypt(string inputText, string AESKey, string AESIV)
        {
            RijndaelManaged aes = new RijndaelManaged();
            aes.BlockSize = 128;
            if (rbtn128.IsChecked == true)
                aes.KeySize = 128;
            else if (rbtn192.IsChecked == true)
                aes.KeySize = 192;
            else
                aes.KeySize = 256;
            aes.Padding = PaddingMode.PKCS7;
            if (rbtnECB.IsChecked == true)
                aes.Mode = CipherMode.ECB;
            else
                aes.Mode = CipherMode.CBC;
            aes.Key = System.Text.Encoding.UTF8.GetBytes(AESKey);

            if (rbtnCBC.IsChecked == true)
                aes.IV = System.Text.Encoding.UTF8.GetBytes(AESIV);

            ICryptoTransform decryptor = aes.CreateDecryptor();

            byte[] encrypted = System.Convert.FromBase64String(inputText);
            byte[] planeText = new byte[encrypted.Length];

            MemoryStream memoryStream = new MemoryStream(encrypted);
            CryptoStream cryptStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);

            cryptStream.Read(planeText, 0, planeText.Length);

            return (System.Text.Encoding.UTF8.GetString(planeText));
        }

        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            if (rbtnEncryption.IsChecked == true)
            {
                txtProcessed.Text = encrypt(txtInput.Text, txtKey.Text, txtIV.Text);
                if (chbExpMode.IsChecked == true)
                {
                    AESSlideshow aesSlide = new AESSlideshow();
                    aesSlide.Show();
                }
            }
            else
                txtProcessed.Text = decrypt(txtInput.Text, txtKey.Text, txtIV.Text);
        }

        private void rbtnCBC_Checked(object sender, RoutedEventArgs e)
        {
            txtIV.IsEnabled = true;
        }

        private void rbtnEncryption_Checked(object sender, RoutedEventArgs e)
        {
            txtProcessed.Text = "Encrypted Text...";
            btnProcess.Content = "Encrypt";
            chbExpMode.IsEnabled = true;
        }

        private void rbtnDecryption_Checked(object sender, RoutedEventArgs e)
        {
            txtProcessed.Text = "Decrypted Text...";
            btnProcess.Content = "Decrypt";
            chbExpMode.IsEnabled = false;
        }

        private void rbtnECB_Checked(object sender, RoutedEventArgs e)
        {
            txtIV.IsEnabled = false;
        }

        private void rbtn128_Checked(object sender, RoutedEventArgs e)
        {
            txtKey.Mask = "&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&";
        }
        private void rbtn192_Checked(object sender, RoutedEventArgs e)
        {
            txtKey.Mask = "&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&";
        }
        private void rbtn256_Checked(object sender, RoutedEventArgs e)
        {
            txtKey.Mask = "&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&";
        }
    }
}
