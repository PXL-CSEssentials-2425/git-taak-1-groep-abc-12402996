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

namespace BerkeOzdemirGitTaak1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Berke.Background = new SolidColorBrush(Colors.White);
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Berke.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            colourCode.Text = "#008000";
        }

        private void Image_MouseUp_1(object sender, MouseButtonEventArgs e)
        {
            colourCode.Text = "#0000FF";
        }

        private void Image_MouseUp_2(object sender, MouseButtonEventArgs e)
        {
            colourCode.Text = "#FFFF00";
        }

        private void Image_MouseUp_3(object sender, MouseButtonEventArgs e)
        {
            colourCode.Text = "#FF0000";
        }
    }
}