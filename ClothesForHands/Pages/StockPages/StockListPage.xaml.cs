using ClothesForHands.AppServices;
using ClothesForHands.Data;
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

namespace ClothesForHands.Pages.StockPages
{
    /// <summary>
    /// Логика взаимодействия для StockListPage.xaml
    /// </summary>
    public partial class StockListPage : Page
    {
        public StockListPage()
        {
            InitializeComponent();
            DgrMaterials.ItemsSource = DbConnect.entObj.Material.ToList();
        }

        private void BtnGoBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }
    }
}
