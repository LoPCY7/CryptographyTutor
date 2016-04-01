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

namespace CryptographyTutor.Pages
{
    /// <summary>
    /// Interaction logic for Achievents.xaml
    /// </summary>
    public partial class Achievements : UserControl
    {
        private AchievementBox achievementBox;
        public Achievements()
        {
            InitializeComponent();
            LoadData();
        }
        
        private void LoadData()
        {
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable recipe;
            String query = "select * from tblAchievements";
            recipe = db.GetDataTable(query);

            foreach (DataRow r in recipe.Rows)
            {
                achievementBox = new AchievementBox(r["Name"].ToString(), r["Description"].ToString(), r["Score"].ToString());
                ListBoxItem achievementItem = new ListBoxItem();
                achievementItem.Content = achievementBox;

                achievementsList.Items.Add(achievementItem);
            }
        }
    }
}