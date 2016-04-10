using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptographyTutor.Model
{
    public class SettingsModel
    {
        private string playerName;
        private string playerScore;
        private string accentColour;
        private string selectedTheme;
        private string savePath;
        private string folderSavePath;

        public SettingsModel()
        {
            folderSavePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CryptographyTutor";
            savePath = folderSavePath + "\\save.bin";
            retrieveSave(savePath);
        }
        private void retrieveSave(string sPath)
        {
            string[] saveLines = File.ReadAllLines(sPath, Encoding.UTF8);
            PlayerName = saveLines[0];
            PlayerScore = saveLines[1];
            AccentColour = saveLines[2];
            SelectedTheme = saveLines[3];
        }
        public string PlayerName
        {
            get
            {
                return this.playerName;
            }
            set
            {
                this.playerName = value;
            }
        }

        public string PlayerScore
        {
            get
            {
                return this.playerScore;
            }
            set
            {
                this.playerScore = value;
            }
        }

        public string AccentColour
        {
            get
            {
                return this.accentColour;
            }
            set
            {
                this.accentColour = value;
            }
        }

        public string SelectedTheme
        {
            get
            {
                return this.selectedTheme;
            }
            set
            {
                this.selectedTheme = value;
            }
        }
    }
}
