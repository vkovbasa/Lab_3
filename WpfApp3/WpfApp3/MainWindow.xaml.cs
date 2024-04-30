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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        delegate void FormatNumberDelegate(double number);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void FormatNumber_Click(object sender, RoutedEventArgs e)
        {
            FormatNumberDelegate format = FormatNumberAsCurrency;
            format += FormatNumberWithCommas;
            format += FormatNumberWithTwoPlaces;

            // Виклик методу, який поширює делегат
            format(12345.6789);
        }

        static void FormatNumberAsCurrency(double number)
        {
            // Вивід форматованого числа у текстовому блоку
            (Application.Current.MainWindow as MainWindow).ResultTextBlock.Text += $"A Currency: {number:C}\n";
        }

        static void FormatNumberWithCommas(double number)
        {
            // Вивід форматованого числа у текстовому блоку
            (Application.Current.MainWindow as MainWindow).ResultTextBlock.Text += $"With Commas: {number:N}\n";
        }

        static void FormatNumberWithTwoPlaces(double number)
        {
            // Вивід форматованого числа у текстовому блоку
            (Application.Current.MainWindow as MainWindow).ResultTextBlock.Text += $"With 3 places: {number:.###}\n";
        }
    }
}
