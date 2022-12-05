using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Threading.Tasks;

namespace TextAnalyserApp
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        /// <summary>
        /// при установки влажка passwordBox скрывается, а textBoxPassword становится видимым
        /// </summary>
        private void checkBoxShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            passwordBox.Visibility = Visibility.Collapsed;
            textBoxPassword.Visibility = Visibility.Visible;

            textBoxPassword.Text = passwordBox.Password.ToString();
            textBoxPassword.Focus();
        }

        /// <summary>
        /// при снятии влажка textBoxPassword скрывается, а passwordBox становится видимым
        /// </summary>
        private void checkBoxShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            passwordBox.Visibility = Visibility.Visible;
            textBoxPassword.Visibility = Visibility.Collapsed;

            passwordBox.Password = textBoxPassword.Text;
            passwordBox.Focus();
        }

        /// <summary>
        /// при нажатии на кнопку передает переменную accountName, открывает окно Administrator или Manager и закрывает Authorization
        /// </summary>
        int error = 0;
        private async void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            
            //UserControlMain user = new UserControlMain("", position);
            if (textBoxLogin.Text == "Админ" & passwordBox.Password == "Админ" || textBoxPassword.Text == "Админ")
            {
                error = 0;
                string accountName = textBoxLogin.Text;
                string position = "Администратор";
                MessageBox.Show("Авторизация прошла успешно.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                Administrator administrator = new Administrator(accountName, position);
                administrator.Show();
                Close();
            }
            else if (textBoxLogin.Text == "Менеджер" & passwordBox.Password == "Менеджер" || textBoxPassword.Text == "Менеджер")
            {
                error = 0;
                string accountName = textBoxLogin.Text;
                string position = "Менеджер";
                MessageBox.Show("Авторизация прошла успешно.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                Manager manager = new Manager(accountName, position);
                manager.Show();
                Close();
            } 
            else
            {
                ++error;
                MessageBox.Show($"Введен неверный логин или пароль. После еще {3 - error} некорректных попыток ввод логина и пароля будет заблокировано в течение 15 секунд", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                if (error >= 3)
                {
                    textBoxLogin.IsEnabled = false;
                    passwordBox.IsEnabled = false;
                    checkBoxShowPassword.IsEnabled = false;
                    buttonLogin.IsHitTestVisible = false;
                    await Task.Delay(15000);
                    textBoxLogin.IsEnabled = true;
                    passwordBox.IsEnabled = true;
                    checkBoxShowPassword.IsEnabled = true;
                    buttonLogin.IsHitTestVisible = true;
                    error = 0;
                }
            }
        }

        private void buttonRegister_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В данный момент действие не доступно, будет доработано в следующих обновлениях.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// при нажатии на кнопку buttonExit закрывает программу
        /// </summary>
        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
