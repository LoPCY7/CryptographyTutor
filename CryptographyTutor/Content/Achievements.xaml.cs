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
using System.Data.SQLite;
using System.Data;

namespace CryptographyTutor.Content
{
    /// <summary>
    /// Interaction logic for Achievements.xaml
    /// </summary>
    public partial class Achievements : UserControl
    {
        private SQLiteConnection sqlConnect;
        private SQLiteCommand sqlCommand;
        private SQLiteDataAdapter dataAdapter;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        public Achievements()
        {
            InitializeComponent();
            LoadData();
        }

        private void dbConnect()
        {
            sqlConnect = new SQLiteConnection(@"Data Source = /Database/cDB.db");
        }

        private void LoadData()
        {
            dbConnect();
            sqlConnect.Open();
            sqlCommand = sqlConnect.CreateCommand();
            string CommandText = "select id, desc from mains";
            dataAdapter = new SQLiteDataAdapter(CommandText, sqlConnect);
            DS.Reset();
            dataAdapter.Fill(DS);
            DT = DS.Tables[0];
            //Grid.DataSource = DT;

            sqlConnect.Close();
        }
    }
}
