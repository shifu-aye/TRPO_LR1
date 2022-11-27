using System.Media;
using System.Windows;
using LR_TRPO.Models;
using LR_TRPO.Windows;

namespace LR_TRPO
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"C:\\Users\\alesh\\source\\repos\\LR_TRPO\\LR_TRPO\\Res\\Audio\\Lesginka.wav";
            sp.Load();
            sp.PlayLooping();
            DataBank.Text = "";
            return;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new KeysWindow().Show();
        }
    }
}
