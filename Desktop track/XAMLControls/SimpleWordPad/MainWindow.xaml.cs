using System;
using System.Collections.Generic;
using System.IO;
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

namespace SimpleWordPad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static string filename = "text.txt";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e) 
        {
            bool wordWrap = toggleButtonWrap.IsChecked.Value;
            textBoxEditArea.TextWrapping = wordWrap ? TextWrapping.Wrap : TextWrapping.NoWrap;
        }

        private void ChangeTextFont(object sender, RoutedEventArgs e)
        {
            var font = comboBoxFontFamilies.SelectedItem;
            if (textBoxEditArea != null)
            {
                textBoxEditArea.FontFamily = new FontFamily(font.ToString());
            }
        }

        private void ChangeFontSize(object sender, SelectionChangedEventArgs e)
        {
            var fontSize = (ComboBoxItem)comboBoxFontSizes.SelectedItem;
            if (textBoxEditArea != null)
            {
                textBoxEditArea.FontSize = int.Parse(fontSize.Content.ToString());
            }
        }

        private void buttonLoadClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var reader = new StreamReader(filename);
                using (reader)
                {
                    textBoxEditArea.Text = reader.ReadToEnd();
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Failed to open: " + filename);
            }
        }

        private void buttonSaveClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var writer = new StreamWriter(filename);
                using (writer)
                {
                    writer.Write(textBoxEditArea.Text);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("Failed to save: " + filename);
            }
        }
    }
}
