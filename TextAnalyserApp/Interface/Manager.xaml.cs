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
using System.Windows.Shapes;

namespace TextAnalyserApp
{
    /// <summary>
    /// Логика взаимодействия для Manager.xaml
    /// </summary>
    public partial class Manager : Window
    {
        public Manager(string accountName, string position)
        {
            InitializeComponent();

            //передается имя и должность пользователя
            userControlMain.buttonAccount.Content = "Пользователь: " + accountName + "\nДолжность: " + position;
            userControlMain.AccountName = accountName;
            userControlMain.PositionName = position;
        }
    }
}