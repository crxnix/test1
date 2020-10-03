using payment_remastered_.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace payment_remastered_.Views
{
    /// <summary>
    /// Логика взаимодействия для studentPage.xaml
    /// </summary>
    public partial class studentPage : Page
    {
        public static DataGrid dg = new DataGrid();

        payment5Entities db = new payment5Entities();
        public studentPage()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            studDataGrid.ItemsSource = db.Студент.ToList();
            dg = studDataGrid;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int id = (studDataGrid.SelectedItem as Студент).Код_студента;
            var delstud = db.Студент.Where(d => d.Код_студента == id).Single();
            db.Студент.Remove(delstud);
            db.SaveChanges();
            studDataGrid.ItemsSource = db.Студент.ToList();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            addStud addstud = new addStud();
            addstud.Show();
        }
    }
}
