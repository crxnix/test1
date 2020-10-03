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
    /// Логика взаимодействия для addStud.xaml
    /// </summary>
    public partial class addStud : Window
    {
        payment5Entities db = new payment5Entities();
        
        public addStud()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            CBgrp.ItemsSource = db.Группа.ToList();
            CBgrp.DisplayMemberPath = "Наименование";
            CBgrp.SelectedValuePath = "Код_группы";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Студент addstud = new Студент()
            {
                Фамилия = studSecName.Text,
                Имя = studName.Text,
                Отчество = studMidName.Text,
                Группа = Convert.ToInt32(CBgrp.SelectedValue)
            };
            db.Студент.Add(addstud);
            db.SaveChanges();
            studentPage.dg.ItemsSource = db.Студент.ToList();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
