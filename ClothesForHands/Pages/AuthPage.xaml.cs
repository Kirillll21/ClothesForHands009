using ClothesForHands.AppServices;
using ClothesForHands.Data;
using ClothesForHands.Pages.StockPages;
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

namespace ClothesForHands.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var user = DbConnect.entObj.User.FirstOrDefault(x => x.Login == txbLogin.Text && x.Password == psbPassword.Password);

                if (user == null)
                {
                    MessageBox.Show("Такого пользователя не существует!",
                                    "Уведомление об ошибке",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);
                    txbLogin.Clear();
                    psbPassword.Clear();
                }
                else
                {
                    MessageBox.Show("Добро пожаловать " + txbLogin.Text + "!",
                                    "Успешный вход",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);
                    switch (user.IdRole)
                    {
                        case 1:
                            FrameApp.frmObj.Navigate(new StockPage());
                            break;
                        case 2:
                            FrameApp.frmObj.Navigate(new HelloPage());

                            break;

                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка программы" + ex.ToString(),
                                "Уведомление об ошибке",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
                
            }        
        }
    
    }
}
