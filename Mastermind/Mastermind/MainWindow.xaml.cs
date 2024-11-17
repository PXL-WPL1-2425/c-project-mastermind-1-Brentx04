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

namespace Mastermind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly string[] colors = { "rood", "geel", "oranje", "wit", "groen", "blauw" };

        public MainWindow()
        {
            InitializeComponent();
        }



        private void checkCode_Click(object sender, RoutedEventArgs e)
        {
            string[] colors = { "rood", "geel", "oranje", "wit", "groen", "blauw" };
            Random random = new Random();

            string colorCode = $"{colors[random.Next(colors.Length)]}, " +
                               $"{colors[random.Next(colors.Length)]}, " +
                               $"{colors[random.Next(colors.Length)]}, " +
                               $"{colors[random.Next(colors.Length)]}";


            this.Title = $"Kleurencode: {colorCode}";
        }

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ComboBox box = (ComboBox)sender;
            if (box != null)
            {

                ComboBoxItem item = box.SelectedItem as ComboBoxItem;

                switch (item.Content.ToString().Trim())
                {
                    case "Wit":
                        textBlock1.Background = new SolidColorBrush(Colors.White);
                        break;
                    case "Groen":
                        textBlock1.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case "Blauw":
                        textBlock1.Background = new SolidColorBrush(Colors.Blue);
                        break;
                    case "Rood":
                        textBlock1.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case "Geel":
                        textBlock1.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case "Oranje":
                        textBlock1.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    default:

                        break;
                }
            }
        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            if (box != null)
            {

                ComboBoxItem item = box.SelectedItem as ComboBoxItem;

                switch (item.Content.ToString().Trim())
                {
                    case "Wit":
                        textBlock2.Background = new SolidColorBrush(Colors.White);
                        break;
                    case "Groen":
                        textBlock2.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case "Blauw":
                        textBlock2.Background = new SolidColorBrush(Colors.Blue);
                        break;
                    case "Rood":
                        textBlock2.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case "Geel":
                        textBlock2.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case "Oranje":
                        textBlock2.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    default:

                        break;
                }
            }
        }

        private void comboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            if (box != null)
            {

                ComboBoxItem item = box.SelectedItem as ComboBoxItem;

                switch (item.Content.ToString().Trim())
                {
                    case "Wit":
                        textBlock3.Background = new SolidColorBrush(Colors.White);
                        break;
                    case "Groen":
                        textBlock3.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case "Blauw":
                        textBlock3.Background = new SolidColorBrush(Colors.Blue);
                        break;
                    case "Rood":
                        textBlock3.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case "Geel":
                        textBlock3.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case "Oranje":
                        textBlock3.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    default:

                        break;
                }
            }
        }

        private void comboBox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            if (box != null)
            {

                ComboBoxItem item = box.SelectedItem as ComboBoxItem;

                switch (item.Content.ToString().Trim())
                {
                    case "Wit":
                        textBlock4.Background = new SolidColorBrush(Colors.White);
                        break;
                    case "Groen":
                        textBlock4.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case "Blauw":
                        textBlock4.Background = new SolidColorBrush(Colors.Blue);
                        break;
                    case "Rood":
                        textBlock4.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case "Geel":
                        textBlock4.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case "Oranje":
                        textBlock4.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    default:

                        break;
                }
            }

        }
    }
}