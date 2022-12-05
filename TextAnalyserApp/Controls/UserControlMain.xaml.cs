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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TextAnalyserApp
{
    /// <summary>
    /// Логика взаимодействия для UserControlMain.xaml
    /// </summary>
    public partial class UserControlMain : UserControl, INotifyPropertyChanged
    {
        
        public event PropertyChangedEventHandler PropertyChanged;
        private string textAccountName;
        public string AccountName
        {
            get
            {
                return textAccountName;
            }
            set
            {
                textAccountName = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("r"));
                }
            }
        }
        private string textPosition;
        public string PositionName
        {
            get
            {
                return textPosition;
            }
            set
            {
                textPosition = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("r"));
                }
            }
        }

        
        public UserControlMain()
        {
            DataContext = this;
            InitializeComponent();
        }

        private void buttonSelectionFile_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В данный момент действие не доступно, будет доработано в следующих обновлениях.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void buttonSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В данный момент действие не доступно, будет доработано в следующих обновлениях.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void buttonAnalyze_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В данный момент действие не доступно, будет доработано в следующих обновлениях.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void buttonClear_Click(object sender, RoutedEventArgs e)
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

        /// <summary>
        /// при нажатии на кнопку buttonAccount откроется окно Authorization и закроется MainWindow
        /// </summary>
        private void buttonAccount_Click(object sender, RoutedEventArgs e)
        {
            Authorization authorization = new Authorization();
            authorization.Show();
            Window.GetWindow(this).Close();
        }

        private void buttonReference_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В данный момент действие не доступно, будет доработано в следующих обновлениях.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void buttonOptions_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("В данный момент действие не доступно, будет доработано в следующих обновлениях.", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// при нажатии buttonApply, в зависимости от выбранных radiobutton и checkbox, выполняет определенные действия
        /// </summary>
        private void buttonApply_Click(object sender, RoutedEventArgs e)
        {
            if (radioButtonRus.IsChecked == true)
            {
                buttonSelectionFile.Content = "Выбор файла";
                buttonSave.Content = "Сохранить текст";
                buttonAnalyze.Content = "Проанализировать текст";
                buttonClear.Content = "Очистить текст";
                buttonExit.Content = "Выход";
                buttonAccount.Content = "Пользователь: " + AccountName + "\nДолжность: " + PositionName;
                textBlockVowels.Text = "Количество гласных:";
                textBlockConsonants.Text = "Количество согласных:";
                textBlockSymbols.Text = "Количество символов-цифр:";
                textBlockPunctuationMarks.Text = "Количество знаков препинания:";
                textBlockEnteredText.Text = "Введенный текст";
                textBlockPathFile.Text = "Путь к файлу";
                buttonReference.Content = "Справка";
                buttonOptions.Content = "Настройки";
                textBlockLanguages.Text = "Выбор языка:";
                radioButtonRus.Content = "Русский";
                radioButtonEng.Content = "Английский";
                textBlockUnnecessary.Text = "Выбор ненужных полей:";
                checkBoxVowels.Content = "Количество гласных";
                checkBoxConsonants.Content = "Количество согласных";
                checkBoxSymbols.Content = "Количество символов-цифр";
                checkBoxPunctuationMarks.Content = "Количество знаков препинания";
                buttonApply.Content = "Применить выбранное";
            }
            else if (radioButtonEng.IsChecked == true)
            {
                buttonSelectionFile.Content = "File selection";
                buttonSave.Content = "Save text";
                buttonAnalyze.Content = "Analyze text";
                buttonClear.Content = "Clear text";
                buttonExit.Content = "Exit";
                buttonAccount.Content = "User: " + AccountName + "\nPosition: " + PositionName;
                textBlockVowels.Text = "Number of vowels:";
                textBlockConsonants.Text = "Number of consonants:";
                textBlockSymbols.Text = "Number of symbols:";
                textBlockPunctuationMarks.Text = "Number of punctuation marks";
                textBlockEnteredText.Text = "Entered text";
                textBlockPathFile.Text = "Path to the file";
                buttonReference.Content = "Reference";
                buttonOptions.Content = "Options";
                textBlockLanguages.Text = "Selection language:";
                radioButtonRus.Content = "Russian";
                radioButtonEng.Content = "English";
                textBlockUnnecessary.Text = "Selection of unnecessary fields:";
                checkBoxVowels.Content = "Number of vowels";
                checkBoxConsonants.Content = "Number of consonants";
                checkBoxSymbols.Content = "Number of symbols";
                checkBoxPunctuationMarks.Content = "Number of punctuation marks";
                buttonApply.Content = "Apply selected";
            }


            if (checkBoxVowels.IsChecked == true)
            {
                textBlockVowels.Visibility = Visibility.Collapsed;
                textBlockOutPutVowels.Visibility = Visibility.Collapsed;
            }
            else
            {
                textBlockVowels.Visibility = Visibility.Visible;
                textBlockOutPutVowels.Visibility = Visibility.Visible;
            }


            if (checkBoxConsonants.IsChecked == true)
            {
                textBlockConsonants.Visibility = Visibility.Collapsed;
                textBlockOutPutConsonants.Visibility = Visibility.Collapsed;
            }
            else
            {
                textBlockConsonants.Visibility = Visibility.Visible;
                textBlockOutPutConsonants.Visibility = Visibility.Visible;
            }


            if (checkBoxSymbols.IsChecked == true)
            {
                textBlockSymbols.Visibility = Visibility.Collapsed;
                textBlockOutPutSymbols.Visibility = Visibility.Collapsed;
            }
            else
            {
                textBlockSymbols.Visibility = Visibility.Visible;
                textBlockOutPutSymbols.Visibility = Visibility.Visible;
            }


            if (checkBoxPunctuationMarks.IsChecked == true)
            {
                textBlockPunctuationMarks.Visibility = Visibility.Collapsed;
                textBlockOutPutPunctuationMarks.Visibility = Visibility.Collapsed;
            }
            else
            {
                textBlockPunctuationMarks.Visibility = Visibility.Visible;
                textBlockOutPutPunctuationMarks.Visibility = Visibility.Visible;
            }
        }
    }
}
