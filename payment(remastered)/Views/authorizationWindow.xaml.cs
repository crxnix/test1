using payment_remastered_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
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
    /// Логика взаимодействия для authorizationWindow.xaml
    /// </summary>
    public partial class authorizationWindow : Window
    {
        public static int idADmin;
        payment5Entities db = new payment5Entities();

        public authorizationWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool x = true;
            for(int i = 0; i<db.Бухгалтер.Count(); i++)
            {
                if((db.Бухгалтер.ToList()[i].Логин == login.Text) && (db.Бухгалтер.ToList()[i].Пароль == password.Password))
                {
                    x = false;
                    MainWindow mw = new MainWindow();
                    mw.Show();
                    idADmin = db.Бухгалтер.ToList()[i].Код_бухгалтера;
                    
                    this.Close();

                }
            }
            if (x)
            {
                MessageBox.Show("Неверный логин или пароль");
                login.Text = string.Empty;
                password.Password = string.Empty;
            }
            
        }
    }
}
