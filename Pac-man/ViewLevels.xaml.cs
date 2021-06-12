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

namespace Pac_man
{
    /// <summary>
    /// Логика взаимодействия для ViewLevels.xaml
    /// </summary>
    public partial class ViewLevels : Window
    {
        public ViewLevels()
        {
            InitializeComponent();
        }

        private void lvl1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Извини брат, там занятный баг при переходе"); 
        }

        private void lvl2(object sender, RoutedEventArgs e)
        {
            Level2 lv = new Level2();
            lv.Show();
        }

        private void lvl3(object sender, RoutedEventArgs e)
        {

        }

        private void lvl4(object sender, RoutedEventArgs e)
        {

        }

        private void lvl5(object sender, RoutedEventArgs e)
        {

        }

        private void lvl6(object sender, RoutedEventArgs e)
        {

        }

        private void lvl7(object sender, RoutedEventArgs e)
        {

        }

        private void lvl8(object sender, RoutedEventArgs e)
        {

        }

        private void lvl9(object sender, RoutedEventArgs e)
        {

        }

        private void lvl10(object sender, RoutedEventArgs e)
        {

        }

        private void exit_click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
