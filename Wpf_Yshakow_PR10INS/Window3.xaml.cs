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
using System.Windows.Shapes;

namespace Wpf_Yshakow_PR10INS
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            image1.Source = new BitmapImage(new Uri("photo/black_bread.jpg", UriKind.Relative));
        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {
            image1.Source = new BitmapImage(new Uri("photo/2957.jpg", UriKind.Relative));
        }

        private void ListBoxItem_Selected_2(object sender, RoutedEventArgs e)
        {
            image1.Source = new BitmapImage(new Uri("photo/22.jpg", UriKind.Relative));
        }

        private void ListBoxItem_Selected_3(object sender, RoutedEventArgs e)
        {
            image1.Source = new BitmapImage(new Uri("photo/pretzel.jpg", UriKind.Relative));
        }

        private void ListBoxItem_Selected_4(object sender, RoutedEventArgs e)
        {
            image1.Source = new BitmapImage(new Uri("photo/photo.jpg", UriKind.Relative));
        }

        private void ListBoxItem_Selected_5(object sender, RoutedEventArgs e)
        {
            image1.Source = new BitmapImage(new Uri("photo/5-francuzskie-bulochki.jpg", UriKind.Relative));
        }

        private void ListBoxItem_Selected_6(object sender, RoutedEventArgs e)
        {
            image1.Source = new BitmapImage(new Uri("photo/IMG_1988.jpg", UriKind.Relative));
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            listbox1.Items.Add(textbox1.Text);
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            listbox1.Items.Remove(listbox1.SelectedItem);
        }

        private void Sort_Click(object sender, RoutedEventArgs e)
        {
            listbox1.Items.SortDescriptions.Add(new System.ComponentModel.SortDescription("Content", System.ComponentModel.ListSortDirection.Ascending));
        }
    }
}
