using ClothesForHands.AppServices;
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
    /// Логика взаимодействия для StockMenuPage.xaml
    /// </summary>
    public partial class StockMenuPage : Page
    {
        public StockMenuPage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void btnGoStock_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new StockPage());
        }

        private void btnGoStuffList_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new StockListPage());
        }
    }
}
