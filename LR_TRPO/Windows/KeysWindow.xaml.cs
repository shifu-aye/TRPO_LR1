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

namespace LR_TRPO.Windows
{
    /// <summary>
    /// Логика взаимодействия для KeysWindow.xaml
    /// </summary>
    public partial class KeysWindow : Window
    {
        public KeysWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void AcceptBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            switch (numTab.Text)
            {
                case "01":
                    mainWindow.ProductTb.Text += Convert.ToString("Шаурма|150 рублей");
                    break;
                case "02":
                    mainWindow.ProductTb.Text = "Кебаб|150 рублей";
                    break;
                default:
                    MessageBox.Show("Такого продукта нет", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
            }

            Close();
        }

        private void oneBtn_Click(object sender, RoutedEventArgs e)
        {
            numTab.Text += "1";
        }

        private void twoBtn_Click(object sender, RoutedEventArgs e)
        {
            numTab.Text += "2";
        }

        private void threeBtn_Click(object sender, RoutedEventArgs e)
        {
            numTab.Text += "3";
        }

        private void fourBtn_Click(object sender, RoutedEventArgs e)
        {
            numTab.Text += "4";
        }

        private void fiveBtn_Click(object sender, RoutedEventArgs e)
        {
            numTab.Text += "5";
        }

        private void sixBtn_Click(object sender, RoutedEventArgs e)
        {
            numTab.Text += "6";
        }

        private void sevenBtn_Click(object sender, RoutedEventArgs e)
        {
            numTab.Text += "7";
        }

        private void eightBtn_Click(object sender, RoutedEventArgs e)
        {
            numTab.Text += "8";
        }

        private void nineBtn_Click(object sender, RoutedEventArgs e)
        {
            numTab.Text += "9";
        }

        private void zeroBtn_Click(object sender, RoutedEventArgs e)
        {
            numTab.Text += "0";
        }

        private void CBtn_Click(object sender, RoutedEventArgs e)
        {
            numTab.Text = "";
        }

        private void XBtn_Click(object sender, RoutedEventArgs e)
        {
            if (numTab.Text != "")
            {
                int x1 = 0;
                x1 = numTab.Text.Length - 1;
                numTab.Text = numTab.Text.Substring(0, x1);
                
            }
        }
    }
}
