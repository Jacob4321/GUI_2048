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

namespace GUI_2048
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

        private void ChoiceBoard(object sender, RoutedEventArgs e)
        {
            ChoiceBoard ChoiceBoatd = new ChoiceBoard();
            ChoiceBoatd.Show();
            this.Close();
        }

        private void Control(object sender, RoutedEventArgs e)
        { 
            Control Control = new Control();
            Control.Show();
            this.Close();
        }

        private void Information(object sender, RoutedEventArgs e)
        {
            Information Information = new Information();
            Information.Show();
            this.Close();
        }

        private void exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
