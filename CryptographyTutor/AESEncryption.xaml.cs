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
    /// Interaction logic for Window1.xaml
    /// </summary>
    /// 
    public partial class Window1 : Window
    {
        public enum KeySize { Bits128, Bits192, Bits256 };  // key size, in bits, for construtor

        private int Nb;         // block size in 32-bit words.  Always 4 for AES.  (128 bits).
        private int Nk;         // key size in 32-bit words.  4, 6, 8.  (128, 192, 256 bits).
        private int Nr;         // number of rounds. 10, 12, 14.

        private byte[] key;     // the seed key. size will be 4 * keySize from ctor.
        private byte[,] Sbox;   // Substitution box
        private byte[,] iSbox;  // inverse Substitution box
        private byte[,] w;      // key schedule array.
        private byte[,] Rcon;   // Round constants.
        private byte[,] State;  // State matrix

        public Window1(KeySize keySize, byte[] keyBytes)
        {
            InitializeComponent();
            //SetNbNkNr(keySize);

            this.key = new byte[this.Nk * 4];  // 16, 24, 32 bytes
            keyBytes.CopyTo(this.key, 0);

            //BuildSbox();
            //BuildInvSbox();
            //BuildRcon();
            //KeyExpansion();  // expand the seed key into a key schedule and store in w

        }  // Aes constructor

        public void Cipher(byte[] input, byte[] output)
        { // encipher 16-bit input
          // state = input
            this.State = new byte[4, Nb];  // always [4,4]

            for (int i = 0; i < (4 * Nb); ++i)
            {
                this.State[i % 4, i / 4] = input[i];
            }

            //AddRoundKey(0);

            for (int round = 1; round <= (Nr - 1); ++round)
            { // main round loop
                //SubBytes();
                //ShiftRows();
                //MixColumns();
                //AddRoundKey(round);
            }  // main round loop

            //SubBytes();

            //ShiftRows();

            //AddRoundKey(Nr);

            // output = state
            for (int i = 0; i < (4 * Nb); ++i)
            {
                output[i] = this.State[i % 4, i / 4];
            }

        }  // Cipher()

        static void DisplayAsBytes(byte[] bytes)
        {

            /*for (int i = 0; i < bytes.Length; ++i)
            {
                System.Console.Write(bytes[i].ToString("x2") + " ");
                if (i > 0 && i % 16 == 0) System.Console.WriteLine();
            }
            System.Console.WriteLine();*/
        }

/*        private static string byte2Hex(byte[] bytes)
        {

            System.Text.StringBuilder sb = new System.Text.StringBuilder(bytes.Length * 2);

            foreach (byte b in bytes)
                sb.AppendFormat("{0:x2}", b);

            return sb.ToString();
        }

        public static byte[] hex2Byte(string hexString)
        {

           /* int n = hexString.Length;

            byte[] bytes = new byte[n / 2];

            for (int i = 0; i < n; i += 2)
                bytes[i / 2] = System.Convert.ToByte(hexString.Substring(i, 2), 16);

            return bytes;
        }
       */
        private void button_Click(object sender, RoutedEventArgs e)
        {
          /*  string plain = textBox.Text;
            byte[] plainText = System.Text.Encoding.UTF8.GetBytes(plain);

            Console.WriteLine("\nThe plaintext is: ");
            DisplayAsBytes(plainText);
            System.Console.WriteLine(byte2Hex(plainText));

            byte[] cipherText;
            byte[] decipheredText;
            byte[] keyBytes = hex2Byte(txtKey.Text.ToString());

            Console.WriteLine("\nUsing a " + Window1.KeySize.Bits256.ToString() + "-key of: ");
            DisplayAsBytes(keyBytes);
            System.Console.WriteLine(byte2Hex(keyBytes));

            cipherText = encrypt(plainText, keyBytes);

            Console.WriteLine("\nThe resulting ciphertext is: ");
            DisplayAsBytes(cipherText);
            System.Console.WriteLine(byte2Hex(cipherText));

            decipheredText = decrypt(cipherText, keyBytes);

            Console.WriteLine("\nAfter deciphering the ciphertext, the result is: ");
            DisplayAsBytes(decipheredText);
            System.Console.WriteLine(byte2Hex(decipheredText));
            System.Console.WriteLine(">>>{0}<<<", System.Text.Encoding.UTF7.GetString(decipheredText));

            Console.WriteLine("\nDone");*/
        }
        
    }
}
