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
using System.Collections.ObjectModel;

using static BakeryKul.ClassHelper.CardProductClass;
using BakeryKul.ClassHelper;
using BakeryKul.Windows;
using static BakeryKul.ClassHelper.EFClass;

namespace BakeryKul.Windows
{
    /// <summary>
    /// Логика взаимодействия для CardWindow.xaml
    /// </summary>
    public partial class CardWindow : Window
    {
        public CardWindow()
        {
            InitializeComponent();

            tbxUser.Text = UserDataClass.user.Login;
            LvCardProd.ItemsSource = CardProductClass.products;
        }

        private void BtnBack1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnBuyProduct1_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
