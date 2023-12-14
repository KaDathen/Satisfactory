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

namespace Satisfactory
{
    /// <summary>
    /// Логика взаимодействия для Product.xaml
    /// </summary>
    public partial class Product : Page
    {
        public Product()
        {
            InitializeComponent();
            //var allTypes = SatisfactoryEntities.GetContext().TypeCom().ToList();
            //allTypes.Insert(0, "ВсеТипы");
           //ComboType.ItemsSource = allTypes;
            ComboType.SelectedIndex = 0;
            UpdateProduct();
        }
        private void UpdateProduct()
        {
            var currentMaterials = SatisfactoryEntities.GetContext().Products.ToList();
            if (ComboType.SelectedIndex > 0)
            {
                currentMaterials = currentMaterials.Where(p => p.ТипПродукта == ComboType.Items[ComboType.SelectedIndex].ToString()).ToList();
            }
            currentMaterials = currentMaterials.Where(p => p.Наименование.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();


            LVistMaterials.ItemsSource = currentMaterials.OrderBy(p => p.Наименование).ToList();

        }
        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
