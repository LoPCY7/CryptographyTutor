using CryptographyTutor.Model;
using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows.Controls;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CryptographyTutor
{
    /// <summary>
    /// Interaction logic for WelcomePage.xaml
    /// </summary>
    public partial class WelcomePage : ModernWindow
    {

        string savePath;
        string folderSavePath;

        public WelcomePage()
        {
            InitializeComponent();
            folderSavePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\CryptographyTutor";
            savePath = folderSavePath + "\\save.bin";
            checkSave(savePath);
        }

        private void checkSave(string sPath)
        {
            if (File.Exists(sPath) == true)
            {
                retrieveSave();
                MainWindow mainWindow = new MainWindow();
                this.Close();
                mainWindow.Show();
            }
        }

        private void retrieveSave()
        {
            SettingsModel newModel = new SettingsModel();
            Color accentColour = (Color)ColorConverter.ConvertFromString(newModel.AccentColour);
            AppearanceManager.Current.AccentColor = accentColour;
            if (newModel.SelectedTheme == "Dark")
                AppearanceManager.Current.ThemeSource = AppearanceManager.DarkThemeSource;
            else
                AppearanceManager.Current.ThemeSource = AppearanceManager.LightThemeSource;
        }

        public void createSave(string playerName)
        {
            Directory.CreateDirectory(folderSavePath);
            File.Create(savePath).Close();
            TextWriter tw = new StreamWriter(savePath);
            tw.WriteLine(playerName);
            tw.WriteLine("0");
            tw.WriteLine(AppearanceManager.Current.AccentColor.ToString());
            if (AppearanceManager.Current.ThemeSource == AppearanceManager.DarkThemeSource)
                tw.WriteLine("Dark");
            else
                tw.WriteLine("Light");
            tw.Close();
            MainWindow mainWindow = new MainWindow();
            this.Close();
            mainWindow.Show();
        }
    }
}
