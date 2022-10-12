using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LR_TRPO.Windows;

namespace LR_TRPO
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"C:\\Users\\alesh\\source\\repos\\LR_TRPO\\LR_TRPO\\Res\\Audio\\Lesginka.wav";
            sp.Load();
            sp.PlayLooping();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            KeysWindow keysWindow = new KeysWindow();
            keysWindow.Show();
        }
    }
}
