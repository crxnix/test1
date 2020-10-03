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
    /// Логика взаимодействия для groupPage.xaml
    /// </summary>
    public partial class groupPage : Page
    {
        public static DataGrid dg = new DataGrid();
        payment5Entities db = new payment5Entities();
        public groupPage()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            grpDataGrid.ItemsSource = db.Группа.ToList();
            dg = grpDataGrid;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            addGrp grp = new addGrp();
            grp.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int id = (grpDataGrid.SelectedItem as Группа).Код_группы;
            var delgrp = db.Группа.Where(d => d.Код_группы == id).Single();
            db.Группа.Remove(delgrp);
            db.SaveChanges();
            grpDataGrid.ItemsSource = db.Группа.ToList();
        }
    }
}
