using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
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

        private void Field_Button2_Click(object sender, RoutedEventArgs e)
        {
            this.Field_tab.IsSelected = true;
        }

        private void New_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Soon!!!");
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Soon!!!");
        }

        private void Load_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Soon!!!");
        }

        private void Reset_Button_Click(object sender, RoutedEventArgs e)
        {
            this.check_box1.IsChecked = false; this.check_box2.IsChecked = false; this.check_box3.IsChecked = false; this.check_box4.IsChecked = false; this.check_box5.IsChecked = false;
            this.check_box6.IsChecked = false;
            this.combo_box1.SelectedIndex =0;
        }

        private void Load_image_Click(object sender, RoutedEventArgs e)
        {
            
            OpenFileDialog pic = new OpenFileDialog();
            pic.Title = " Select a picture";
            pic.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
        "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
        "Portable Network Graphic (*.png)|*.png";
            if (pic.ShowDialog()==true)
            {
                picture_external.Source = new BitmapImage(new Uri(pic.FileName));

            }

        }
    }
}
