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

        int error = 0;


        private void Login()
        {
            if (textBoxLogin.Text == "Админ" & passwordBox.Password == "Админ" || textBoxPassword.Text == "Админ")
            {
                error = 0;
                string accountName = textBoxLogin.Text;
                string role = "Администратор";
                MessageBox.Show("Авторизация прошла успешно.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                Administrator administrator = new Administrator(accountName, role);
                administrator.Show();
                Close();
            }
            else if (textBoxLogin.Text == "Менеджер" & passwordBox.Password == "Менеджер" || textBoxPassword.Text == "Менеджер")
            {
                error = 0;
                string accountName = textBoxLogin.Text;
                string role = "Менеджер";
                MessageBox.Show("Авторизация прошла успешно.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
                Manager manager = new Manager(accountName, role);
                manager.Show();
                Close();
            }
            else
            {
                Error();
            }
        }

        private async void Error()
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

        /// <summary>
        /// при установке флажка в textBoxPassword передается значение из passwordBox
        /// </summary>
        private void checkBoxShowPassword_Checked(object sender, RoutedEventArgs e)
        {

            textBoxPassword.Text = passwordBox.Password.ToString();
        }

        /// <summary>
        /// при снятии флажка в passwordBox передается значение из textBoxPassword
        /// </summary>
        private void checkBoxShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            passwordBox.Password = textBoxPassword.Text;
        }

        /// <summary>
        /// при нажатии на кнопку передает переменную accountName, открывает окно Administrator или Manager и закрывает Authorization
        /// </summary>
        private void buttonLogin_Click(object sender, RoutedEventArgs e)
        {
            if (passwordBox.Focus() & passwordBox.Password == "" & textBoxPassword.Text != "" || textBoxPassword.Focus() & textBoxPassword.Text == "" & passwordBox.Password != "")
            {
                passwordBox.Password = "";
                textBoxPassword.Text = "";
                Error();
            }
            else
            {
                Login();
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
