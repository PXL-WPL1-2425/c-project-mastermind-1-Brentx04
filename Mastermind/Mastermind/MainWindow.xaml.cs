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
                        Label1.Background = new SolidColorBrush(Colors.White);
                        break;
                    case "Groen":
                        Label1.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case "Blauw":
                        Label1.Background = new SolidColorBrush(Colors.Blue);
                        break;
                    case "Rood":
                        Label1.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case "Geel":
                        Label1.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case "Oranje":
                        Label1.Background = new SolidColorBrush(Colors.Orange);
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
                        Label2.Background = new SolidColorBrush(Colors.White);
                        break;
                    case "Groen":
                        Label2.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case "Blauw":
                        Label2.Background = new SolidColorBrush(Colors.Blue);
                        break;
                    case "Rood":
                        Label2.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case "Geel":
                        Label2.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case "Oranje":
                        Label2.Background = new SolidColorBrush(Colors.Orange);
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
                        Label3.Background = new SolidColorBrush(Colors.White);
                        break;
                    case "Groen":
                        Label3.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case "Blauw":
                        Label3.Background = new SolidColorBrush(Colors.Blue);
                        break;
                    case "Rood":
                        Label3.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case "Geel":
                        Label3.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case "Oranje":
                        Label3.Background = new SolidColorBrush(Colors.Orange);
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
                        Label4.Background = new SolidColorBrush(Colors.White);
                        break;
                    case "Groen":
                        Label4.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case "Blauw":
                        Label4.Background = new SolidColorBrush(Colors.Blue);
                        break;
                    case "Rood":
                        Label4.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case "Geel":
                        Label4.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case "Oranje":
                        Label4.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    default:

                        break;
                }
            }

        }
    }
    //commit 4
}