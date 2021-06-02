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
    /// Логика взаимодействия для MainGameWindow.xaml
    /// </summary>
    public partial class MainGameWindow : Window
    {
        public MainGameWindow()
        {
            InitializeComponent();
        }

        private void Click_game(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Извини, но данная кнопка плохо работает");
            
        }

        private void Click_levels(object sender, RoutedEventArgs e)
        {
            ViewLevels vl = new ViewLevels();
            vl.Show();
        }

        private void Click_exit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
