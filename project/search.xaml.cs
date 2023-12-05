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

namespace project
{
    /// <summary>
    /// Interaction logic for search.xaml
    /// </summary>
    public partial class search : Page
    {
        cityEntities3 db=new cityEntities3();
        public search()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            userr n = db.userrs.FirstOrDefault(x => x.City.Contains(cc.Text));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            datag.ItemsSource= db.userrs.ToList();
        }
    }
}
