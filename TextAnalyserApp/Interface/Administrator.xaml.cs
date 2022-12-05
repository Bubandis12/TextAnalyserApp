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

namespace TextAnalyserApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Administrator : Window
    {
        //internal String accountsName;
        public Administrator(string accountName, string role)
        {
            InitializeComponent();

            //передается имя и должность пользователя
            userControlMain.buttonAccount.Content = "Логин: " + accountName + "\nРоль: " + role;
            userControlMain.AccountName = accountName;
            userControlMain.RoleName = role;
        }
    }
}
