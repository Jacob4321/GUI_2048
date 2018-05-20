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

namespace GUI_2048
{
    /// <summary>
    /// Interaction logic for ChoiceBoard.xaml
    /// </summary>
    public partial class ChoiceBoard : Window
    {
        public ChoiceBoard()
        {
            InitializeComponent();
        }
        private void Board4x4(object sender, RoutedEventArgs e)
        {
            Board4x4 Board4x4 = new Board4x4();
            Board4x4.Show();
            this.Close(); 
        }

        private void Board6x6(object sender, RoutedEventArgs e)
        {
            Board6x6 Board6x6 = new Board6x6();
            Board6x6.Show();
            this.Close();
        }

        private void Board8x8(object sender, RoutedEventArgs e)
        {
            Board8x8 Board8x8 = new Board8x8();
            Board8x8.Show();
            this.Close();

        }

        private void exit(object sender, RoutedEventArgs e)
        {
            MainWindow exit = new MainWindow();
            exit.Show();
            this.Close();
        }

        
    }
}
