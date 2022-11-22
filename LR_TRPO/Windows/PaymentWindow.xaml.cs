using LR_TRPO.Models;
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

namespace LR_TRPO.Windows
{
    /// <summary>
    /// Логика взаимодействия для PaymentWindow.xaml
    /// </summary>
    public partial class PaymentWindow : Window
    {
        public int money;
        public string text;
        public int remains;
        public PaymentWindow(String current_text, int current_money)
        {
            InitializeComponent();
            remains = new User().Remains; 
            money = current_money;
            text = current_text;
            tbTextFromKeys.Text = text;
            tbTextInput.Text = "0";
            tbTextYourMoney.Text = money.ToString();
        }

        private void OneHundredBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(tbTextYourMoney.Text) > 0)
            {
                tbTextYourMoney.Text = Convert.ToString(Convert.ToInt32(tbTextYourMoney.Text) - 100);
                tbTextInput.Text = Convert.ToString(Convert.ToInt32(tbTextInput.Text) + 100);
            }
        }
        private void FiftyBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(tbTextYourMoney.Text) > 0)
            {
                tbTextYourMoney.Text = Convert.ToString(Convert.ToInt32(tbTextYourMoney.Text) - 50);
                tbTextInput.Text = Convert.ToString(Convert.ToInt32(tbTextInput.Text) + 50);
            }
        }

        private void TenBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(tbTextYourMoney.Text) > 0)
            {
                tbTextYourMoney.Text = Convert.ToString(Convert.ToInt32(tbTextYourMoney.Text) - 10);
                tbTextInput.Text = Convert.ToString(Convert.ToInt32(tbTextInput.Text) + 10);
            }
        }

        private void FiveBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(tbTextYourMoney.Text) > 0)
            {
                tbTextYourMoney.Text = Convert.ToString(Convert.ToInt32(tbTextYourMoney.Text) - 5);
                tbTextInput.Text = Convert.ToString(Convert.ToInt32(tbTextInput.Text) + 5);
            }
        }

        private void TwoBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(tbTextYourMoney.Text) > 0)
            {
                tbTextYourMoney.Text = Convert.ToString(Convert.ToInt32(tbTextYourMoney.Text) - 2);
                tbTextInput.Text = Convert.ToString(Convert.ToInt32(tbTextInput.Text) + 2);
            }
        }

        private void OneBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(tbTextYourMoney.Text) > 0)
            {
                tbTextYourMoney.Text = Convert.ToString(Convert.ToInt32(tbTextYourMoney.Text) - 1);
                tbTextInput.Text = Convert.ToString(Convert.ToInt32(tbTextInput.Text) + 1);
            }
        }

        private void PayBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (text)
                {
                    case "Шаурма, 200 рублей":
                        if (Convert.ToInt32(tbTextInput.Text) >= 200 && money >= 200)
                        {
                            money -= 200;
                            remains = Convert.ToInt32(tbTextInput.Text) - 200;
                            MessageBox.Show($"Оплата прошла! Текущий баланс: {money} Сдача: {remains}", "Операция прошла успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
                            if (remains != 0)
                                MessageBox.Show($"Внимание! Сдача в размере {remains} рублей будет автоматически выдана внизу автомата", "Обратите внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                            money += remains;
                            Close();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Недостаточно средств!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                            break;
                        }
                    case "Люля-Кебаб, 200 рублей":
                        if (Convert.ToInt32(tbTextInput.Text) >= 200 && money >= 200)
                        {
                            money -= 200; 
                            remains = Convert.ToInt32(tbTextInput.Text) - 200;

                            MessageBox.Show($"Оплата прошла! Текущий баланс: {money} Сдача: {remains}", "Операция прошла успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
                            if (remains != 0)
                                MessageBox.Show($"Внимание! Сдача в размере {remains} рублей будет автоматически выдана внизу автомата", "Обратите внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                            money += remains;
                            Close();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Недостаточно средств!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                            break;
                        }
                    case "Элеш, 70 рублей":
                        if (Convert.ToInt32(tbTextInput.Text) >= 70 && money >= 70)
                        {
                            money -= 70;
                            remains = Convert.ToInt32(tbTextInput.Text) - 70;
                            MessageBox.Show($"Оплата прошла! Текущий баланс: {money} Сдача: {remains}", "Операция прошла успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
                            if (remains != 0)
                                MessageBox.Show($"Внимание! Сдача в размере {remains} рублей будет автоматически выдана внизу автомата", "Обратите внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                            money += remains;
                            Close();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Недостаточно средств!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                            break;
                        }
                    case "Лагман, 120 рублей":
                        if (Convert.ToInt32(tbTextInput.Text) >= 120 && money >= 120)
                        {
                            money -= 120;
                            remains = Convert.ToInt32(tbTextInput.Text) - 120;
                            MessageBox.Show($"Оплата прошла! Текущий баланс: {money} Сдача: {remains}", "Операция прошла успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
                            if (remains != 0)
                                MessageBox.Show($"Внимание! Сдача в размере {remains} рублей будет автоматически выдана внизу автомата", "Обратите внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                            money += remains;
                            Close();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Недостаточно средств!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                            break;
                        }
                    case "Самса, 80 рублей":
                        if (Convert.ToInt32(tbTextInput.Text) >= 80 && money >= 80 )
                        {
                            money -= 80;
                            remains = Convert.ToInt32(tbTextInput.Text) - 80;
                            MessageBox.Show($"Оплата прошла! Текущий баланс: {money} Сдача: {remains}", "Операция прошла успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
                            if (remains != 0)
                                MessageBox.Show($"Внимание! Сдача в размере {remains} рублей будет автоматически выдана внизу автомата", "Обратите внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                            money += remains;
                            Close();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Недостаточно средств!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                            break;
                        }
                    case "Компот, 40 рублей":
                        if (Convert.ToInt32(tbTextInput.Text) >= 40 && money >= 40)
                        {
                            money -= 40;
                            remains = Convert.ToInt32(tbTextInput.Text) - 40;
                            MessageBox.Show($"Оплата прошла! Текущий баланс: {money} Сдача: {remains}", "Операция прошла успешно!", MessageBoxButton.OK, MessageBoxImage.Information);
                            if (remains != 0)
                                MessageBox.Show($"Внимание! Сдача в размере {remains} рублей будет автоматически выдана внизу автомата", "Обратите внимание", MessageBoxButton.OK, MessageBoxImage.Information);
                            money += remains;
                            Close();
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Недостаточно средств!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
