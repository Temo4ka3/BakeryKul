using BakeryKul.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryKul.ClassHelper
{
    internal class CardProductClass
    {
        public static List<Product> products = new List<Product>();
        public static ObservableCollection<Product> observableCollectionProduct = new ObservableCollection<Product>(ClassHelper.CardProductClass.products);
    }
}
