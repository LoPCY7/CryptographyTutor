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
using CryptographyTutor.CMethods;

namespace CryptographyTutor
{
    /// <summary>
    /// Interaction logic for FinalAES.xaml
    /// </summary>

    public partial class FinalAES : Window
    {
        public enum Mode { ECB, CBC }
        public enum KeySize { b128, b192, b256 }
        public Mode aesMode;
        public KeySize keySize;
        private const int cBlockSizeInBytes = 16;

        public FinalAES()
        {
            InitializeComponent();
              
        }

        private void setSize()
        {
            if (rbtn128.IsChecked == true)
                keySize = KeySize.b128;
            if (rbtn192.IsChecked == true)
                keySize = KeySize.b192;
            if (rbtn256.IsChecked == true)
                keySize = KeySize.b256;
        }

        /* PKCS5/PKCS7 compliant padding */
        private static byte[] appendPadding(byte[] data)
        {

            int cnt = data.Length;
            int paddingLenght = cBlockSizeInBytes - (cnt % cBlockSizeInBytes);
            int paddedLenght = cnt + paddingLenght;
            byte[] res = new byte[paddedLenght];

            for (int i = 0; i < paddedLenght; i++)
                res[i] = (i < cnt) ? data[i] : (byte)paddingLenght;

            //System.Console.WriteLine("paddedLenght=" + paddingLenght);
            //DisplayAsBytes(res);
            return res;
        }

        private static byte[] removePadding(byte[] paddedData)
        {

            int paddedLength = paddedData.Length;
            int cnt = 1;

            for (int i = paddedLength - 1; i >= 0; i--, cnt++)
                if (paddedData[i] != paddedData[i - 1]) break;

            if ((cnt % cBlockSizeInBytes) != (int)paddedData[paddedLength - 1])
                throw new System.Exception("Padding error: cnt=" + cnt +
                                            "; bs=" + cBlockSizeInBytes + "; byte=" +
                                            paddedData[paddedLength - 1] + ";");

            byte[] res = new byte[paddedLength - cnt];

            for (int i = 0; i < paddedLength - cnt; i++)
                res[i] = paddedData[i];

            return res;
        }

        private byte[] encryptECB(byte[] input, byte[] key)
        {
            AESClass aesRun;
            byte[] result;
            if (keySize == KeySize.b128)
                aesRun = new AESClass(AESClass.KeySize.b128, key);
            else if (keySize == KeySize.b192)
                aesRun = new AESClass(AESClass.KeySize.b192, key);
            else
                aesRun = new AESClass(AESClass.KeySize.b256, key); 
            input = appendPadding(input);
            result = new byte[input.Length];
            aesRun.Cipher(input, result);

            return result;
        }

        private byte[] decryptECB(byte[] input, byte[] key)
        {
            AESClass aesRun;
            byte[] result = new byte[input.Length];
            if (keySize == KeySize.b128)
                aesRun = new AESClass(AESClass.KeySize.b128, key);
            else if (keySize == KeySize.b192)
                aesRun = new AESClass(AESClass.KeySize.b192, key);
            else
                aesRun = new AESClass(AESClass.KeySize.b256, key);
            aesRun.InvCipher(input, result);
            result = removePadding(result);

            return result;
        }

    }
}
