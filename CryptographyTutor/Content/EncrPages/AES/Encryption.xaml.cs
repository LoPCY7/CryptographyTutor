using CryptographyTutor.CMethods;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace CryptographyTutor.Content.EncrPages.AES
{
    /// <summary>
    /// Interaction logic for Encryption.xaml
    /// </summary>
    public partial class Encryption : UserControl
    {

        [DllImport("kernel32.dll",
            EntryPoint = "GetStdHandle",
            SetLastError = true,
            CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr GetStdHandle(int nStdHandle);
        [DllImport("kernel32.dll",
            EntryPoint = "AllocConsole",
            SetLastError = true,
            CharSet = CharSet.Auto,
            CallingConvention = CallingConvention.StdCall)]
        private static extern int AllocConsole();
        private const int STD_OUTPUT_HANDLE = -11;
        private const int MY_CODE_PAGE = 437;


        public enum Mode { ECB, CBC }
        public enum KeySize { b128, b192, b256 }
        public Mode aesMode;
        public KeySize keySize;
        private const int cBlockSizeInBytes = 16;
        public Encryption()
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
            setSize();
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
            setSize();
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
        private void btnEncrypt_Click(object sender, RoutedEventArgs e)
        {
            AllocConsole();
            IntPtr stdHandle = GetStdHandle(STD_OUTPUT_HANDLE);
            SafeFileHandle safeFileHandle = new SafeFileHandle(stdHandle, true);
            FileStream fileStream = new FileStream(safeFileHandle, FileAccess.Write);
            Encoding encoding = System.Text.Encoding.GetEncoding(MY_CODE_PAGE);
            StreamWriter standardOutput = new StreamWriter(fileStream, encoding);
            standardOutput.AutoFlush = true;
            Console.SetOut(standardOutput);
            string plain = txtInput.Text;
            byte[] plainText = System.Text.Encoding.UTF8.GetBytes(plain);

            Console.WriteLine("\nThe plaintext is: ");
            DisplayAsBytes(plainText);
            System.Console.WriteLine(byte2Hex(plainText));

            byte[] cipherText;
            byte[] decipheredText;
            byte[] keyBytes = hex2Byte(txtKey.Text);

            Console.WriteLine("\nUsing a " + AESClass.KeySize.b128.ToString() + "-key of: ");
            DisplayAsBytes(keyBytes);
            System.Console.WriteLine(byte2Hex(keyBytes));

            cipherText = encryptECB(plainText, keyBytes);

            Console.WriteLine("\nThe resulting ciphertext is: ");
            DisplayAsBytes(cipherText);
            System.Console.WriteLine(byte2Hex(cipherText));

            decipheredText = decryptECB(cipherText, keyBytes);

            Console.WriteLine("\nAfter deciphering the ciphertext, the result is: ");
            DisplayAsBytes(decipheredText);
            System.Console.WriteLine(byte2Hex(decipheredText));
            System.Console.WriteLine(">>>{0}<<<", System.Text.Encoding.UTF7.GetString(decipheredText));

            Console.WriteLine("\nDone");
        }


        private static string byte2Hex(byte[] bytes)
        {

            System.Text.StringBuilder sb = new System.Text.StringBuilder(bytes.Length * 2);

            foreach (byte b in bytes)
                sb.AppendFormat("{0:x2}", b);

            return sb.ToString();
        }

        public static byte[] hex2Byte(string hexString)
        {

            int n = hexString.Length;

            byte[] bytes = new byte[n / 2];

            for (int i = 0; i < n; i += 2)
                bytes[i / 2] = System.Convert.ToByte(hexString.Substring(i, 2), 16);

            return bytes;
        }

        static void DisplayAsBytes(byte[] bytes)
        {

            for (int i = 0; i < bytes.Length; ++i)
            {
                System.Console.Write(bytes[i].ToString("x2") + " ");
                if (i > 0 && i % 16 == 0) System.Console.WriteLine();
            }
            System.Console.WriteLine();
        }

        private void btnEncrypt_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
