using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

using static BakeryKul.ClassHelper.EFClass;
using BakeryKul.Windows;

namespace BakeryKul.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegistrWindow.xaml
    /// </summary>
    public partial class RegistrWindow : Window
    {
        public RegistrWindow()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            if (tbxPass.Password == " " || tbxLogin.Text == " " || tbxEmail.Text == " ")
            {
                MessageBox.Show("Проверьте ввели ли вы данные");
            }
            else if (tbxPass.Password.Length < 8)
            {
                MessageBox.Show("Пароль должен состоять не менее чем из 8 символов");
            }

            ContextDB.User.Add(new DB.User
            {
                Login = tbxLogin.Text,
                Password = tbxPass.Password,
                Email = tbxEmail.Text,
                RoleID = 1,
            }); ;

            ContextDB.SaveChanges();

            MessageBox.Show("OK");


            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
