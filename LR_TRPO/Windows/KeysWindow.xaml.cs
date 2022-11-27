using System.Windows;
using LR_TRPO.Models;

namespace LR_TRPO.Windows
{
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
            switch (NumTab.Text)
            {
                case "01":
                    DataBank.Text = "Шаурма, 200 рублей";
                    new PaymentWindow(DataBank.Text, new User().Money).Show();
                    break;
                case "02":
                    DataBank.Text = "Люля-Кебаб, 200 рублей";
                    new PaymentWindow(DataBank.Text, new User().Money).Show();
                    break;
                case "03":
                    DataBank.Text = "Элеш, 70 рублей";
                    new PaymentWindow(DataBank.Text, new User().Money).Show();
                    break;
                case "04":
                    DataBank.Text = "Лагман, 120 рублей";
                    new PaymentWindow(DataBank.Text, new User().Money).Show();
                    break;
                case "05":
                    DataBank.Text = "Самса, 80 рублей";
                    new PaymentWindow(DataBank.Text, new User().Money).Show();
                    break;
                case "06":
                    DataBank.Text = "Компот, 40 рублей";
                    new PaymentWindow(DataBank.Text, new User().Money).Show();
                    break;
                default:
                    MessageBox.Show("Такого продукта нет", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    break;
            }
            Close();
        }

        private void oneBtn_Click(object sender, RoutedEventArgs e)
        {
            NumTab.Text += "1";
        }

        private void twoBtn_Click(object sender, RoutedEventArgs e)
        {
            NumTab.Text += "2";
        }

        private void threeBtn_Click(object sender, RoutedEventArgs e)
        {
            NumTab.Text += "3";
        }

        private void fourBtn_Click(object sender, RoutedEventArgs e)
        {
            NumTab.Text += "4";
        }

        private void fiveBtn_Click(object sender, RoutedEventArgs e)
        {
            NumTab.Text += "5";
        }

        private void sixBtn_Click(object sender, RoutedEventArgs e)
        {
            NumTab.Text += "6";
        }

        private void sevenBtn_Click(object sender, RoutedEventArgs e)
        {
            NumTab.Text += "7";
        }

        private void eightBtn_Click(object sender, RoutedEventArgs e)
        {
            NumTab.Text += "8";
        }

        private void nineBtn_Click(object sender, RoutedEventArgs e)
        {
            NumTab.Text += "9";
        }

        private void zeroBtn_Click(object sender, RoutedEventArgs e)
        {
            NumTab.Text += "0";
        }

        private void CBtn_Click(object sender, RoutedEventArgs e)
        {
            NumTab.Text = "";
        }

        private void XBtn_Click(object sender, RoutedEventArgs e)
        {
            if (NumTab.Text != "")
            {
                int x1 = 0;
                x1 = NumTab.Text.Length - 1;
                NumTab.Text = NumTab.Text.Substring(0, x1);
                
            }
        }
    }
}
