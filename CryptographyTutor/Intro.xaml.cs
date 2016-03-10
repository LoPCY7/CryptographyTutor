using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for Intro.xaml
    /// </summary>
    public partial class Intro : Window
    {
        string savePath;
        string folderSavePath;

        public Intro()
        {
            InitializeComponent();
            folderSavePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\CryptographyTutor";
            savePath = folderSavePath + "\\save.bin";
            checkSave(savePath);
        }

        private void checkSave(string sPath)
        {
            if (File.Exists(sPath)==true)
            {
                GameWindow tutor = new GameWindow(0);
                this.Close();
                tutor.Show();
            }
        }

        private void createSave(string playerName)
        {
            Directory.CreateDirectory(folderSavePath);
            File.Create(savePath).Close();
            TextWriter tw = new StreamWriter(savePath);
            tw.WriteLine(playerName);
            tw.Close();
        }

        private void btnConfirmName_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Is your name "+textBox.Text+"?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                String playerName = textBox.Text;
                TutorialWindow tutorialWindow = new TutorialWindow(playerName);
                createSave(playerName);
                this.Close();
                tutorialWindow.Show();
            }
        }
    }
}
