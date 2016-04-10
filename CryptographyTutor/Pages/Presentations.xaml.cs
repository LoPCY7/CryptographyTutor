using System;
using System.Collections.Generic;
using System.Data;
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

namespace CryptographyTutor.Pages
{
    /// <summary>
    /// Interaction logic for Presentations.xaml
    /// </summary>
    public partial class Presentations : UserControl
    {
        private PresentationBox presentationBox;
        public Presentations()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            SQLiteDatabase db = new SQLiteDatabase();
            DataTable recipe;
            String query = "select * from tblPresentations";
            recipe = db.GetDataTable(query);

            foreach (DataRow r in recipe.Rows)
            {
                presentationBox = new PresentationBox(r["ID"].ToString(), r["Name"].ToString());
                ListBoxItem presentationItem = new ListBoxItem();
                presentationItem.Content = presentationBox;

                presentationsList.Items.Add(presentationItem);
            }
        }
    }
}
