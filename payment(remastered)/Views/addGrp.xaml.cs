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
using System.Windows.Shapes;

namespace payment_remastered_.Views
{
    /// <summary>
    /// Логика взаимодействия для addGrp.xaml
    /// </summary>
    public partial class addGrp : Window
    {
        payment5Entities db = new payment5Entities();
        public addGrp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Группа newgrp = new Группа
            {
                Наименование = grpName.Text
            };
            db.Группа.Add(newgrp);
            db.SaveChanges();
            groupPage.dg.ItemsSource = db.Группа.ToList();
            this.Close();
        }
    }
}
