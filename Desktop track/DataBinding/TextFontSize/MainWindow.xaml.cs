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

namespace TextFontSize
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

        private void ButtonMaxClick(object sender, RoutedEventArgs e)
        {
            SliderFont.Value = SliderFont.Maximum;
        }

        private void ButtonDefaultClick(object sender, RoutedEventArgs e)
        {
            SliderFont.Value = 12;
        }

        private void ButtonMinClick(object sender, RoutedEventArgs e)
        {
            SliderFont.Value = SliderFont.Minimum;
        }
    }
}
