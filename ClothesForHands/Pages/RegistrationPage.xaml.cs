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

namespace ClothesForHands.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new AuthPage());
        }

        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            if (DbConnect.entObj.User.Count(x => x.Login == txbLogin.Text) > 0)
            {
                MessageBox.Show("Такой пользователь уже есть!",
                    "Уведомление",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
                return;
            }
            else
            {
                try
                {
                    if (txbLogin.Text == "")
                    {
                        MessageBox.Show("Критический сбой",
                                        "Уведомление",
                                        MessageBoxButton.OK,
                                        MessageBoxImage.Warning);
                    }

                    User userObj = new User()
                    {
                        Login = txbLogin.Text,
                        Password = psbPassword.Password,                       
                        IdRole = 1
                    };

                    DbConnect.entObj.User.Add(userObj);
                    DbConnect.entObj.SaveChanges();

                    MessageBox.Show("Пользователь создан!",
                        "Уведомление",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);

                    FrameApp.frmObj.Navigate(new HelloPage());
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка работы приложения: " + ex.Message.ToString(),
                    "Критический сбой работы приложения",
                    MessageBoxButton.OK,
                    MessageBoxImage.Warning);
                }
            }
        }
    }
}
