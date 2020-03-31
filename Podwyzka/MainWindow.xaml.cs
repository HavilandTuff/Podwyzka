using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Podwyzka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            buttonYES.Background = Brushes.Green;
            buttonNO.Background = Brushes.Red;
        }

        private void ButtonYES_MouseEnter(object sender, MouseEventArgs e)
        {
            if(sender.Equals(buttonYES) && buttonYES.Content.ToString() == "TAK")
            {
                buttonYES.Content = "NIE";
                buttonYES.Background = Brushes.Red;
                buttonNO.Content = "TAK";
                buttonNO.Background = Brushes.Green;
            }
            else if(sender.Equals(buttonNO) && buttonNO.Content.ToString() == "TAK")
            {
                buttonNO.Content = "NIE";
                buttonNO.Background = Brushes.Red;
                buttonYES.Content = "TAK";
                buttonYES.Background = Brushes.Green;
            }
        }

        private void ButtonYES_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Wiec nie dostaniesz podwyżki!");
        }
    }
}
