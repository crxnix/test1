using payment_remastered_.Models;
using payment_remastered_.Views;
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

namespace payment_remastered_
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        payment5Entities db = new payment5Entities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            groupPage addgrp = new groupPage();
            fr.Navigate(addgrp);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            studentPage addstud = new studentPage();
            fr.Navigate(addstud);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //if (db.Бухгалтер.ToList()[1].admin == "true")
            //{
            //    accountantReg AR = new accountantReg();
            //    AR.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Вы не обладаете правами администратора", "Error");
            //}
            //MessageBox.Show((db.Бухгалтер.ToList().[1].admin));

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            payPage pay = new payPage();
            fr.Navigate(pay);
        }
    }
}
