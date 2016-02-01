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
    /// Interaction logic for AESTest2.xaml
    /// </summary>
    public partial class AESTest2 : Window
    {
        public int encryptionMode;
        public AESTest2()
        {
            InitializeComponent();
            encryptionMode = 0;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (encryptionMode == 0)
            {
                byte[] keyArray = UTF8Encoding.UTF8.GetBytes("12345678901234567890123456789012"); // AES-256 key
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
    }
}
